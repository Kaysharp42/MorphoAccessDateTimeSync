using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MorphoAccessDateTimeSync
{
    public class Core
    {
		public ArrayList ErrorValue(byte e)
		{
			ArrayList arrayList = new ArrayList();
			if (e != 0)
			{
				switch (e)
				{
					case 157:
						arrayList.Add(99);
						arrayList.Add("The application is not yet implemented");
						return arrayList;
					case 188:
						arrayList.Add(68);
						arrayList.Add("OSM is locked");
						return arrayList;
					case 189:
						arrayList.Add(67);
						arrayList.Add("After 10 failed IDs, the OtpGenerate request is locked.");
						return arrayList;
					case 190:
						arrayList.Add(66);
						arrayList.Add("After 5 failed enrollments or 5 failed logins, the user enrollment request is locked.");
						return arrayList;
					case 191:
						arrayList.Add(65);
						arrayList.Add("After 5 false pin presentations, the OtpSetParameters request is locked.");
						return arrayList;
					case 196:
						arrayList.Add(60);
						arrayList.Add("No response from the biometric sensor");
						return arrayList;
					case 209:
						arrayList.Add(47);
						arrayList.Add("");
						return arrayList;
					case 210:
						arrayList.Add(46);
						arrayList.Add("Pin needed for the first enrolment");
						return arrayList;
					case 211:
						arrayList.Add(45);
						arrayList.Add("Identification failed (Status is invalid unless DB error)");
						return arrayList;
					case 212:
						arrayList.Add(44);
						arrayList.Add("enrolment failed");
						return arrayList;
					case 213:
						arrayList.Add(43);
						arrayList.Add("Re-enrollment not allowed");
						return arrayList;
					case 214:
						arrayList.Add(42);
						arrayList.Add("No Hit (or latent or FFD)");
						return arrayList;
					case 215:
						arrayList.Add(41);
						arrayList.Add("OTP database is empty: you have to register");
						return arrayList;
					case 216:
						arrayList.Add(40);
						arrayList.Add("OTP plus number (sequence number = 0)");
						return arrayList;
					case 217:
						arrayList.Add(39);
						arrayList.Add("Not all OTP settings are initialized");
						return arrayList;
					case 218:
						arrayList.Add(38);
						arrayList.Add("The finger may be too wet or the scanner is wet");
						return arrayList;
					case 219:
						arrayList.Add(37);
						arrayList.Add("Fingerprint detected is false");
						return arrayList;
					case 221:
						arrayList.Add(35);
						arrayList.Add("Mutual authentication error");
						return arrayList;
					case 222:
						arrayList.Add(34);
						arrayList.Add("Cryptographic error");
						return arrayList;
					case 223:
						arrayList.Add(33);
						arrayList.Add("Error while decoding an ASN1 object");
						return arrayList;
					case 224:
						arrayList.Add(32);
						arrayList.Add("An anti-error system has occurred Replay");
						return arrayList;
					case 225:
						arrayList.Add(31);
						arrayList.Add("The security status is invalid");
						return arrayList;
					case 226:
						arrayList.Add(30);
						arrayList.Add("The required certificate does not exist");
						return arrayList;
					case 227:
						arrayList.Add(29);
						arrayList.Add("Fingers presented do not match");
						return arrayList;
					case 228:
						arrayList.Add(28);
						arrayList.Add("There are two models of the same finger");
						return arrayList;
					case 229:
						arrayList.Add(27);
						arrayList.Add("La commande a été annulée");
						return arrayList;
					case 230:
						arrayList.Add(26);
						arrayList.Add("L'Identifiant utilisateur requis n'a pas été trouvé dans la base");
						return arrayList;
					case 231:
						arrayList.Add(25);
						arrayList.Add("Clés de sécurité ne peut être changé");
						return arrayList;
					case 232:
						arrayList.Add(24);
						arrayList.Add("Longuer ou nom du Champ est invalide");
						return arrayList;
					case 233:
						arrayList.Add(23);
						arrayList.Add("Champ introuvable");
						return arrayList;
					case 234:
						arrayList.Add(22);
						arrayList.Add("Pointeuse ne peut pas être accordée à cause du temps, accorder avec le fuseau horaire");
						return arrayList;
					case 235:
						arrayList.Add(21);
						arrayList.Add("Le nombre des champs additionnels est supérieur à 8");
						return arrayList;
					case 236:
						arrayList.Add(20);
						arrayList.Add("Une erreur s'est produite durant la configuration des paramétres réseau TCPIP");
						return arrayList;
					case 237:
						arrayList.Add(19);
						arrayList.Add("Une erreur s'est produite durant la configuration du Wiegand/Dataclock");
						return arrayList;
					case 238:
						arrayList.Add(18);
						arrayList.Add("Une erreur s'est produite durant la configuration du Serial Link");
						return arrayList;
					case 239:
						arrayList.Add(17);
						arrayList.Add("Une erreur s'est produite lors de la lecture de la carte");
						return arrayList;
					case 240:
						arrayList.Add(16);
						arrayList.Add("La vérification de la signature a échoué");
						return arrayList;
					case 241:
						arrayList.Add(15);
						arrayList.Add("Mode adiminstrateur en utilisation");
						return arrayList;
					case 242:
						arrayList.Add(14);
						arrayList.Add("La base de données ne peut être crée, il n’y a plus d’espace mémoire suffisant");
						return arrayList;
					case 243:
						arrayList.Add(13);
						arrayList.Add("Type flash invalide");
						return arrayList;
					case 244:
						arrayList.Add(12);
						arrayList.Add("Une autre commande est en cours d'exécution");
						return arrayList;
					case 245:
						arrayList.Add(11);
						arrayList.Add("Une opération biométrique en cours, réessayer plus tard");
						return arrayList;
					case 246:
						arrayList.Add(10);
						arrayList.Add("L’identifiant de la base de données est erroné, cette base existe déjà");
						return arrayList;
					case 247:
						arrayList.Add(9);
						arrayList.Add("Base introuvable");
						return arrayList;
					case 248:
						arrayList.Add(8);
						arrayList.Add("Empreinte existe déjà");
						return arrayList;
					case 249:
						arrayList.Add(7);
						arrayList.Add("The protocol used is not valid");
						return arrayList;
					case 250:
						arrayList.Add(6);
						arrayList.Add("Le temps de détection de doigt est expiré sans aucune réponse");
						return arrayList;
					case 251:
						arrayList.Add(5);
						arrayList.Add("Mauvais identificateur ou longueur non valide");
						return arrayList;
					case 252:
						arrayList.Add(4);
						arrayList.Add("Matricule invalide");
						return arrayList;
					case 253:
						arrayList.Add(3);
						arrayList.Add("Empreinte n'est pas valide");
						return arrayList;
					case 254:
						arrayList.Add(2);
						arrayList.Add("The parameters given are incorrect");
						return arrayList;
					case 255:
						arrayList.Add(1);
						arrayList.Add("An error occurred during the execution of the function");
						return arrayList;
				}
				arrayList.Add(0);
				arrayList.Add("Success of the operation ");
			}
			else
			{
				arrayList.Add(0);
				arrayList.Add("The terminal responds correctly");
			}
			return arrayList;
		}

		public ArrayList StatusValue(byte e)
		{
			ArrayList arrayList = new ArrayList();
			switch (e)
			{
				case 0:
					arrayList.Add(0);
					arrayList.Add("Successful enrollment");
					break;
				case 1:
					arrayList.Add(1);
					arrayList.Add("Login");
					break;
				case 2:
					arrayList.Add(2);
					arrayList.Add("Closing a session");
					break;
				default:
					arrayList.Add(1000000000000L);
					arrayList.Add("an error has occurred...");
					break;
			}
			return arrayList;
		}

		public ArrayList TypeAction(byte e)
		{
			ArrayList arrayList = new ArrayList();
			switch (e)
			{
				case 1:
					break;
				case 2:
					break;
				default:
					if (e != 48)
					{
						arrayList.Add(1000000000000L);
						arrayList.Add("Errorfffff");
					}
					else
					{
						arrayList.Add("Identification");
					}
					break;
			}
			return arrayList;
		}

		public int calculEntier(int d, int f, byte[] ms)
		{
			byte[] value = new byte[0];
			byte[] array = new byte[f - d];
			int num = 0;
			int num2 = ms.Length;
			int result;
			if (num2 > d)
			{
				for (int i = f - 1; i > d - 1; i--)
				{
					array[num] = ms[i];
					num++;
				}
				value = array;
				string text = BitConverter.ToString(value);
				for (int num3 = text.IndexOf("-"); num3 != -1; num3 = text.IndexOf("-"))
				{
					text = text.Remove(num3, 1);
				}
				result = Convert.ToInt32(text, 16);
			}
			else
			{
				result = -1;
			}
			return result;
		}

		public int calculEntierLog(int d, int f, byte[] ms)
		{
			byte[] value = new byte[0];
			byte[] array = new byte[f - d];
			int num = 0;
			int num2 = ms.Length;
			int result;
			if (num2 > d)
			{
				for (int i = d; i < f; i++)
				{
					array[num] = ms[i];
					num++;
				}
				value = array;
				string text = BitConverter.ToString(value);
				for (int num3 = text.IndexOf("-"); num3 != -1; num3 = text.IndexOf("-"))
				{
					text = text.Remove(num3, 1);
				}
				result = Convert.ToInt32(text, 16);
			}
			else
			{
				result = -1;
			}
			return result;
		}

		public string calculString(int d, int f, byte[] ms)
		{
			byte[] bytes = new byte[0];
			byte[] array = new byte[f - d];
			int num = 0;
			int num2 = ms.Length;
			if (num2 > d)
			{
				for (int i = d; i < f; i++)
				{
					array[num] = ms[i];
					num++;
				}
				bytes = array;
			}
			return Encoding.ASCII.GetString(bytes);
		}

		public string calculStr(int d, int f, byte[] ms)
		{
			byte[] value = new byte[0];
			byte[] array = new byte[f - d];
			int num = 0;
			int num2 = ms.Length;
			if (num2 > d)
			{
				for (int i = d; i < f; i++)
				{
					array[num] = ms[i];
					num++;
				}
				value = array;
			}
			return BitConverter.ToString(value);
		}

		public byte[] SocketSendReceive(byte[] requete, string ip)
		{
			try
			{
				this.ConnectSocket(ip);
			}
			catch
			{
				this.erreur = 2;
			}
			try
			{
				this.ClientSocket.Send(requete, requete.Length, SocketFlags.None);
			}
			catch
			{
				this.stop();
			}
			return this.ReceiveData();
		}

		private void ConnectSocket(string Ip)
		{
			int port = 11010;
			IPAddress address = IPAddress.Parse(Ip);
			IPEndPoint remoteEP = new IPEndPoint(address, port);
			this.ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				this.ClientSocket.Connect(remoteEP);
				if (this.ClientSocket.Connected)
				{
					this.Bouclage = true;
					this.erreur = 1;
				}
			}
			catch
			{
				this.erreur = 2;
			}
		}

		public byte[] ReceiveData()
		{
			byte[] array = new byte[0];
			try
			{
				while (this.Bouclage)
				{
					if (this.ClientSocket.Connected)
					{
						if (this.ClientSocket.Poll(10, SelectMode.SelectRead) && this.ClientSocket.Available == 0)
						{
							this.stop();
						}
						if (this.ClientSocket.Available > 0)
						{
							while (this.ClientSocket.Available > 0)
							{
								try
								{
									byte[] array2 = new byte[this.ClientSocket.Available];
									this.ClientSocket.Receive(array2, array2.Length, SocketFlags.None);
									byte[] array3 = new byte[array.Length + array2.Length];
									array.CopyTo(array3, 0);
									array2.CopyTo(array3, array.Length);
									array = array3;
								}
								catch
								{
									this.stop();
								}
							}
						}
					}
				}
			}
			catch
			{
				this.stop();
			}
			return array;
		}

		public void stop()
		{
			try
			{
				this.Bouclage = false;
				if (this.ClientSocket != null)
				{
					while (this.ClientSocket.Connected)
					{
						this.ClientSocket.Shutdown(SocketShutdown.Both);
						this.ClientSocket.Close();
					}
				}
				this.erreur = 2;
			}
			catch
			{
				this.erreur = 6;
			}
		}

		public ArrayList Error()
		{
			ArrayList arrayList = new ArrayList();
			switch (this.erreur)
			{
				case 1:
					arrayList.Add(-1);
					arrayList.Add("connected, all is well");
					return arrayList;
				case 2:
					arrayList.Add(-2);
					arrayList.Add("Connection failure ");
					return arrayList;
				case 3:
					arrayList.Add(-3);
					arrayList.Add("Failure to transmit data");
					return arrayList;
				case 4:
					arrayList.Add(-4);
					arrayList.Add(">> operation in progress please wait");
					return arrayList;
				case 6:
					arrayList.Add(-6);
					arrayList.Add("an error has occurred");
					return arrayList;
			}
			arrayList.Add(-5);
			arrayList.Add("Connection failure");
			return arrayList;
		}
		private bool Bouclage = false;

		private int erreur;

		private Socket ClientSocket = null;
	}
}
