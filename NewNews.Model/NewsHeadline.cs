using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNews.Model
{
	public enum TypeNews
	{
		DJ = 0,
		PLTX = 1,
		WSD = 2,
		EXTR = 3,
		PLRP = 4
	}

	public class NewsHeadline
	{
		private int mIdNewsHeadLine;
		public int IdNewsHeadLine
		{
			get { return mIdNewsHeadLine; }
			set { mIdNewsHeadLine = value; }
		}
		private DateTime mDateGmt;
		public DateTime DateGmt
		{
			get { return mDateGmt; }
			set { mDateGmt = value; }
		}

		private string mHeadline;
		public string Headline
		{
			get { return mHeadline; }
			set { mHeadline = value; }
		}

		private string mMessageSMS;
		public string MessageSMS
		{
			get { return mMessageSMS; }
			set { mMessageSMS = value; }
		}

		private bool mIsHot;
		public bool IsHot
		{
			get { return mIsHot; }
			set { mIsHot = value; }
		}

		private TypeNews mTypeNews;
		public TypeNews TypeNews
		{
			get { return mTypeNews; }
			set { mTypeNews = value; }
		}

		private int? mTendance;
		public int? Tendance
		{
			get { return mTendance; }
			set { mTendance = value; }
		}

		public NewsHeadline(int pIdNewsHeadLine, DateTime pDateGmt, string pHeadline, 
			string pMessageSMS, bool pIsHot, TypeNews pTypeNews, int? pTendance)
		{
			mIdNewsHeadLine = pIdNewsHeadLine;
			mDateGmt = pDateGmt;
			mHeadline = pHeadline;
			mMessageSMS = pMessageSMS;
			mIsHot = pIsHot;
			mTypeNews = pTypeNews;
			mTendance = pTendance;
		}
	}
}
