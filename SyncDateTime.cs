using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MorphoAccessDateTimeSync
{
    public static class SyncDateTime
    {
		private static  ArrayList Tab = new ArrayList();
		private static Core Core = new Core();
		public static ArrayList GetDateAndTimeConfiguration(string IpAddress)
		{
			Tab = new ArrayList();
			byte[] requete = new byte[]
			{
				6,
				1,
				0,
				19
			};
			ArrayList result;
			try
			{
				byte[] array = Core.SocketSendReceive(requete, IpAddress);
				Tab = Core.ErrorValue(Core.SocketSendReceive(requete, IpAddress)[3]);
				if (array[3] == 0)
				{
					Tab.Add(DateTime.ParseExact(Core.calculString(8, 20, array), "ddMMyyHHmmss", null));
				}
				result = Tab;
			}
			catch
			{
				result = Core.Error();
			}
			return result;
		}

		public static ArrayList SetDateAndTimeConfiguration(string IpAddress, DateTime DT)
		{
			Tab = new ArrayList();
			string text = DT.ToString("dd/MM/yyyy HH:mm:ss");
			string text2 = text.Remove(2, 1);
			string text3 = text2.Remove(4, 3);
			string text4 = text3.Remove(6, 1);
			string text5 = text4.Remove(8, 1);
			string s = text5.Remove(10, 1);
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			byte[] array = new byte[20];
			byte[] array2 = new byte[]
			{
				1,
				17,
				0,
				0,
				19,
				13,
				0
			};
			array2.CopyTo(array, 0);
			bytes.CopyTo(array, array2.Length);
			array[19] = 0;
			ArrayList result;
			try
			{
				byte[] array3 = Core.SocketSendReceive(array, IpAddress);
				Tab = Core.ErrorValue(Core.SocketSendReceive(array, IpAddress)[3]);
				result = Tab;
			}
			catch
			{
				result = Core.Error();
			}
			return result;
		}
	}
}
