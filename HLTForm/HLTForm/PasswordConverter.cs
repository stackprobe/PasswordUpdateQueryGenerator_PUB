// Processed by SolutionConv >>>
//
// 本ソースファイルは、公開時の所定の手続きとして一部のセンシティブな情報をマスキングしています。
// 元データの機微に触れる可能性がある箇所を伏せ字化したものであり、
// リリース版との処理内容に実質的な差異が生じない範囲で調整を加えています。
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using HLTStudio.Commons;
using HLTStudio.Tools;

namespace HLTStudio
{
	public class PasswordConverter
	{
		private Form Owner;

		public PasswordConverter(Form owner)
		{
			this.Owner = owner;
		}

		public void OutputCsv(string inputCSVFile, string outputCSVFile)
		{
			this.ConvertMain(
				inputCSVFile,
				outputCSVFile,
				() => new CsvFileWriter(outputCSVFile),
				(inputRow, writer) =>
				{
					HashedPassword hp = new HashedPassword(inputRow.Password);

					writer.WriteCell(inputRow.VendorCode);
					writer.WriteCell(inputRow.Password);
					writer.WriteCell(hp.PasswordHash);
					writer.WriteCell(hp.Salt);
					writer.EndRow();
				});
		}

		public void OutputQuery(string inputCSVFile, string outputQueryFile)
		{
			this.ConvertMain(
				inputCSVFile,
				outputQueryFile,
				() => new StreamWriter(outputQueryFile, false, SCommon.ENCODING_SJIS),
				(inputRow, writer) =>
				{
					HashedPassword hp = new HashedPassword(inputRow.Password);

					string updateQuery = StringTools.ReplaceAll(
						Setting.Instance.Value.UpdateQueryTemplate,
						true,
						Consts.UPDATE_QUERY_TEMPLATE_PATTERN_VENDOR_CODE,
						inputRow.VendorCode,
						Consts.UPDATE_QUERY_TEMPLATE_PATTERN_HASHED_PASSWORD,
						hp.PasswordHash,
						Consts.UPDATE_QUERY_TEMPLATE_PATTERN_SALT,
						hp.Salt,
						Consts.UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_USER_ID,
						Setting.Instance.Value.UpdateUserID,
						Consts.UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_PROGRAM_ID,
						Setting.Instance.Value.UpdateProgramID
						);

					writer.WriteLine(updateQuery);
				});
		}

		private class InputRow_t
		{
			public string VendorCode;
			public string Password;
		}

		private void ConvertMain<OUTPUT_STREAM>(string inputCSVFile, string errorFileBase, Func<OUTPUT_STREAM> openOutputStream, Action<InputRow_t, OUTPUT_STREAM> writeInputRow) where OUTPUT_STREAM : IDisposable
		{
			try
			{
				inputCSVFile = SCommon.ToFullPath(inputCSVFile);

				if (!File.Exists(inputCSVFile))
					throw new Exception("入力CSVファイルが存在しません。");

				string errorFile = errorFileBase + "_【エラー情報】.csv";
				int errorCount = 0;

				using (CsvFileReader reader = new CsvFileReader(inputCSVFile))
				using (CsvFileWriter errorWriter = new CsvFileWriter(errorFile))
				using (OUTPUT_STREAM writer = openOutputStream())
				{
					BusyDlg.Show(() =>
					{
						for (int index = 0; ; index++)
						{
							if (BusyDlg.CancelRequested)
							{
								errorWriter.WriteCell((index + 1) + " 行目");
								errorWriter.WriteCell("この行を処理する前に中断しました。");
								errorWriter.EndRow();

								errorCount++;

								break;
							}

							string[] row = reader.ReadRow();

							if (row == null)
							{
								if (index == 0)
								{
									errorWriter.WriteCell("入力データがありません。");
									errorWriter.EndRow();

									errorCount++;
								}
								break;
							}

							try
							{
								if (row.Length < 2)
									throw new Exception("空行または列が足りません。");

								InputRow_t inputRow = new InputRow_t()
								{
									VendorCode = row[0],
									Password = row[1],
								};

								if (!Common.IsValidVendorCode(inputRow.VendorCode))
									throw new Exception("ベンダーコードの書式に問題があります。");

								if (inputRow.Password == "")
									throw new Exception("パスワードが空です。");

								if (StringTools.HasControl(inputRow.Password))
									throw new Exception("パスワードに制御文字が含まれています。");

								if (!StringTools.IsShiftJIS(inputRow.Password))
									throw new Exception("パスワードに Shift_JIS に変換できない文字が含まれています。");

								writeInputRow(inputRow, writer);
							}
							catch (Exception ex)
							{
								errorWriter.WriteCell((index + 1) + " 行目");
								errorWriter.WriteCell(ex.Message);
								errorWriter.WriteCells(row);
								errorWriter.EndRow();

								errorCount++;
							}
						}
					});
				}

				if (errorCount == 0) // / ///// // //
				{
					SCommon.DeletePath(errorFile);

					MessageDlg.Show(this.Owner,
						"全ての変換処理が正常に終了しました。",
						"変換成功",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information
						);
				}
				else // / ///// // //
				{
					MessageDlg.Show(this.Owner,
						errorCount + " 件のエラーが発生しました。\r\n" +
						"エラー情報ファイルを確認して下さい。" +
						"エラー情報ファイル：" + errorFile,
						"変換失敗",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning
						);
				}
			}
			catch (Exception ex)
			{
				MessageDlg.Show(this.Owner, ex.Message, "変換エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}

//
// <<< Processed by SolutionConv
//