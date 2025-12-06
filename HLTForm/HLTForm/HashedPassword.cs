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
using HLTStudio.Commons;

namespace HLTStudio
{
	public class HashedPassword
	{
		private const int PASSWORD_HASH_STRETCHING_COUNT = 10000;
		private const int PASSWORD_HASH_BYTE_SIZE = 32;
		private const int SALT_BYTE_SIZE = 32;

		public string PasswordHash { get; private set; }
		public string Salt { get; private set; }

		public HashedPassword(string password)
			: this(password, CreateSalt())
		{ }

		public HashedPassword(string password, string salt)
		{
			string p = password + salt;

			for (int c = 0; c < PASSWORD_HASH_STRETCHING_COUNT; c++)
				p = SCommon.Base64.I.Encode(SCommon.GetPart(SCommon.GetSHA512(Encoding.UTF8.GetBytes(p)), 0, PASSWORD_HASH_BYTE_SIZE));

			this.PasswordHash = p;
			this.Salt = salt;
		}

		public static string CreateSalt()
		{
			return SCommon.Base64.I.Encode(SCommon.CRandom.GetBytes(SALT_BYTE_SIZE));
		}
	}
}

//
// <<< Processed by SolutionConv
//