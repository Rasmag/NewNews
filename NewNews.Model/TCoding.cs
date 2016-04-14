using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNews.Model
{
	public class TCoding
	{
		private int mIdCoding;
		public int IdCoding
		{
			get { return mIdCoding; }
			set { mIdCoding = value; }
		}

		private string mCoding;
		public string Coding
		{
			get { return mCoding; }
			set { mCoding = value; }
		}

		private string mDescription;
		public string Description
		{
			get { return mDescription; }
			set { mDescription = value; }
		}

		private string mType;
		public string Type
		{
			get { return mType; }
			set { mType = value; }
		}

		public TCoding(int pIdCoding, string pCoding, string pDescription, string pType)
		{
			mIdCoding = pIdCoding;
			mCoding = pCoding;
			mDescription = pDescription;
			mType = pType;
		}

	}
}
