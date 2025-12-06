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
using System.Drawing;
using System.IO;
using HLTStudio.Commons;

namespace HLTStudio
{
	public class Setting
	{
		public static Lazy<Setting> Instance = new Lazy<Setting>(() => new Setting());

		private Setting()
		{
			this.LoadSetting();
		}

		private string SettingFile
		{
			get
			{
				return ProcMain.SelfFile + "_setting.dat";
			}
		}

		private void LoadSetting()
		{
			if (!File.Exists(this.SettingFile))
				return;

			string[] lines = SCommon.Serializer.I.Split(File.ReadAllBytes(this.SettingFile));
			int r = 0;

			{
				int l = int.Parse(lines[r++]);
				int t = int.Parse(lines[r++]);
				int w = int.Parse(lines[r++]);
				int h = int.Parse(lines[r++]);

				this.LastMainWinRect = new Rectangle(l, t, w, h);
			}

			this.UpdateUserID = lines[r++];
			this.UpdateProgramID = lines[r++];
			this.UpdateQueryTemplate = lines[r++];
		}

		public void SaveSetting()
		{
			List<string> dest = new List<string>();

			dest.Add(this.LastMainWinRect.Left.ToString());
			dest.Add(this.LastMainWinRect.Top.ToString());
			dest.Add(this.LastMainWinRect.Width.ToString());
			dest.Add(this.LastMainWinRect.Height.ToString());

			dest.Add(this.UpdateUserID);
			dest.Add(this.UpdateProgramID);
			dest.Add(this.UpdateQueryTemplate);

			File.WriteAllBytes(this.SettingFile, SCommon.Serializer.I.BinJoin(dest));
		}

		/// /////////
		/// //////////////////
		/// ////// // / // ///
		/// //////////
		public Rectangle LastMainWinRect = new Rectangle(0, 0, 0, 0);

		/// /////////
		/// ////////
		/// //////////
		public string UpdateUserID = "9999999";

		/// /////////
		/// /////////
		/// //////////
		public string UpdateProgramID = "HPMK";

		/// /////////
		/// ////////////
		/// //////////
		public string UpdateQueryTemplate = Consts.DEAULT_UPDATE_QUERY_TEMPLATE;
	}
}

//
// <<< Processed by SolutionConv
//