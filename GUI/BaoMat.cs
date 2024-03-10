using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace GUI
{
    public class BaoMat
    {
        private static BaoMat instance;
        public static BaoMat Instance
        {
            get { if (instance == null) instance = new BaoMat(); return instance; }
            private set { BaoMat.instance = value; }
        }
        private BaoMat() { }

        public string MaHoaMatKhau(string matkhau)
        {
            byte[] pass = ASCIIEncoding.ASCII.GetBytes(matkhau);
            byte[] haspass = new MD5CryptoServiceProvider().ComputeHash(pass);
            string stringpass = "";
            for (int i = haspass.Length - 1; i >= 0; i--)
            {
                stringpass += haspass[i];
            }
            return stringpass;
        }

		public bool KiemTraMatKhau(string pwd, int minLength = 8, int numUpper = 1, int numLower = 1, int numNumbers = 1, int numSpecial = 1)
		{

			System.Text.RegularExpressions.Regex upper = new System.Text.RegularExpressions.Regex("[A-Z]");
			System.Text.RegularExpressions.Regex lower = new System.Text.RegularExpressions.Regex("[a-z]");
			System.Text.RegularExpressions.Regex number = new System.Text.RegularExpressions.Regex("[0-9]");
			System.Text.RegularExpressions.Regex special = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");

			if (pwd.Length < minLength)
			{
				return false;
			}
			
			if (upper.Matches(pwd).Count < numUpper)
			{
				return false;
			}
			if (lower.Matches(pwd).Count < numLower)
			{
				return false;
			}
			if (number.Matches(pwd).Count < numNumbers)
			{
				return false;
			}
			if (special.Matches(pwd).Count < numSpecial)
			{
				return false;
			}
			return true;
		}
	}
}
