﻿using Renci.SshNet;

namespace SubirFTP.Logica
{
    internal class comandos
    {
        public String comSSH(String prm_user,String prm_ssh)
        {
            SshCommand res_txt;
            String result;
            if(prm_user == "steam")
            {
                string host = "190.70.140.6";
                string username = "steam";
                string password = "Arma3Gfn";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;

                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            else if(prm_user == "root")
            {
                string host = "190.70.140.6";
                string username = "root";
                string password = "37R664PTNU%";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;

                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }

            if (prm_user == "ts3")
            {
                string host = "190.70.140.6";
                string username = "ts3";
                string password = "ts3";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;

                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            return ("Usuario no reconocido");
            //Passing the sftp host without the "sftp://"
        }



        public String comSSH (String prm_user , String prm_ssh , String prm_ssh2)
        {
            SshCommand res_txt;
            if (prm_user == "steam")
            {
                string host = "190.70.140.6";
                string username = "steam";
                string password = "Arma3Gfn";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            else if (prm_user == "root")
            {
                string host = "190.70.140.6";
                string username = "root";
                string password = "37R664PTNU%";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            return ("Usuario no reconocido");
        }

        public String comSSH(String prm_user,String prm_ssh, String prm_ssh2, String prm_ssh3)
        {
            SshCommand res_txt;
            if (prm_user == "steam")
            {
                string host = "190.70.140.6";
                string username = "steam";
                string password = "Arma3Gfn";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    res_txt = client.RunCommand(prm_ssh3);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            else if (prm_user == "root")
            {
                string host = "190.70.140.6";
                string username = "root";
                string password = "37R664PTNU%";
                var client = new SshClient(host, username, password);
                try
                {
                    client.Connect();
                    res_txt = client.RunCommand(prm_ssh);
                    res_txt = client.RunCommand(prm_ssh2);
                    res_txt = client.RunCommand(prm_ssh3);
                    client.Disconnect();
                    client.Dispose();
                    return res_txt.Result;
                }
                catch (Exception ex)
                {
                    return (ex.ToString());
                }

            }
            return ("Usuario no reconocido");
        }
    }
}
