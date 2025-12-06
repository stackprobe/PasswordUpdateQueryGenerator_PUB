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

namespace HLTStudio
{
	public static class Consts
	{
		/// /////////
		/// ////////////////////////////
		/// //////////
		public static string UPDATE_QUERY_TEMPLATE_PATTERN_VENDOR_CODE = "<VNCD>";

		/// /////////
		/// //////////////////////////////////
		/// //////////
		public static string UPDATE_QUERY_TEMPLATE_PATTERN_HASHED_PASSWORD = "<HSPW>";

		/// /////////
		/// /////////////////////////
		/// //////////
		public static string UPDATE_QUERY_TEMPLATE_PATTERN_SALT = "<SALT>";

		/// /////////
		/// /////////////////////////////
		/// //////////
		public static string UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_USER_ID = "<UUID>";

		/// /////////
		/// //////////////////////////////
		/// //////////
		public static string UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_PROGRAM_ID = "<UPID>";

		/// /////////
		/// //////////////////
		/// //////////
		public static string DEAULT_UPDATE_QUERY_TEMPLATE = string.Format(@"

UPDATE MST_PASSWORD_TABLE SET
    HASHED_PASSWORD   = '{1}'
  , SALT              = '{2}'
  , UPDATE_DATE       = SYSDATE
  , UPDATE_USER_ID    = '{3}'
  , UPDATE_PROGRAM_ID = '{4}'
WHERE VENDOR_CODE     = '{0}'
/

			".Trim()
			, UPDATE_QUERY_TEMPLATE_PATTERN_VENDOR_CODE
			, UPDATE_QUERY_TEMPLATE_PATTERN_HASHED_PASSWORD
			, UPDATE_QUERY_TEMPLATE_PATTERN_SALT
			, UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_USER_ID
			, UPDATE_QUERY_TEMPLATE_PATTERN_UPDATE_PROGRAM_ID
			);
	}
}

//
// <<< Processed by SolutionConv
//