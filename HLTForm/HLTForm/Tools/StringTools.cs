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
using System.Windows.Forms;
using HLTStudio.Commons;

namespace HLTStudio.Tools
{
	public static class StringTools
	{
		public static bool HasControl(string str)
		{
			return str.Any(chr => chr < ' ');
		}

		public static bool HasControlWithoutTabCRLF(string str)
		{
			return str.Any(chr => chr < ' '
				&& chr != '\t'
				&& chr != '\r'
				&& chr != '\n'
				);
		}

		public static bool IsShiftJIS(string str)
		{
			try
			{
				byte[] b = SCommon.ENCODING_SJIS.GetBytes(str);
				string s = SCommon.ENCODING_SJIS.GetString(b);
				return s == str;
			}
			catch
			{
				return false;
			}
		}

		public static void CopyToClipboard(string text)
		{
			if (string.IsNullOrEmpty(text))
				Clipboard.Clear();
			else
				Clipboard.SetText(text);
		}

		public static string GetCopiedToClipboardMessage()
		{
			DateTime now = DateTime.Now;

			return $"[{now.Hour:D2}:{now.Minute:D2}:{now.Second:D2}.{now.Millisecond:D3}] コピーしました";
		}

		/// /////////
		/// ///////////////////////////
		/// /////////////////////////////
		/// //////////////// //////////// //////////// //////////// //////////// //////////// //////////// /// //
		/// ///
		/// /////////////// ///////////// ///////////// // / //////////////// // // // // // // //////
		/// / / // / // / / / ////////////////////////////////////
		/// //////////
		/// ////// /////////////////////////////
		/// ////// //////////////////////////////////////
		/// ////// /////////////////////////////////////////
		/// ////////////////////////////
		public static string ReplaceAll(string text, bool ignoreCase, params string[] patterns)
		{
			if (
				patterns.Length == 0 ||
				patterns.Length % 2 != 0 ||
				patterns.Where((pattern, index) => index % 2 == 0).Any(pattern => pattern == "") // / ///////////////////
				)
				throw new Exception("Bad patterns");

			StringBuilder buff = new StringBuilder();

			for (int index = 0; index < text.Length;)
			{
				for (int p = 0; ; p += 2)
				{
					if (patterns.Length <= p)
					{
						buff.Append(text[index]);
						index++;
						break;
					}

					if (
						index + patterns[p].Length <= text.Length &&
						IsMatchPattern(text, index, patterns[p], ignoreCase)
						)
					{
						buff.Append(patterns[p + 1]);
						index += patterns[p].Length;
						break;
					}
				}
			}
			return buff.ToString();
		}

		private static bool IsMatchPattern(string text, int offset, string pattern, bool ignoreCase)
		{
			for (int index = 0; index < pattern.Length; index++)
			{
				char chr1 = text[offset + index];
				char chr2 = pattern[index];

				if (ignoreCase)
				{
					chr1 = char.ToLower(chr1);
					chr2 = char.ToLower(chr2);
				}
				if (chr1 != chr2)
					return false;
			}
			return true;
		}
	}
}

//
// <<< Processed by SolutionConv
//