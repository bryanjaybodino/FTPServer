
Complete Standard FTP Server using C#


            int port = 2022;
            string directory = "C://";

            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = ni.GetIPProperties();
                    foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses)
                    {
                        Console.WriteLine("ftp://"+ip.Address.ToString()+":"+port);
                    }
                }
            }

       
            Commands commands = new Commands(directory, port);
            await commands.StartAsync();



            
Command List 

PWD
CWD
PASV
LIST
STOR
RETR
DELE
RMD
MKD
RNFR
RNTO
QUIT
NOOP
TYPE
SITE
OPTS
PORT





<img width="960" alt="Screenshot FTP" src="https://github.com/user-attachments/assets/1a28fedb-512c-4dbb-b997-db8284b2b25a">
