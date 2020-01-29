using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXM.OEE
{
    public class Linha
    {


        public int id { get; set; }
        public int cont { get; set; }
        // caracteristicas dinamica:
        public int cont_in { get; set; }
        public int cont_out { get; set; }
        public bool maq_sts { get; set; }
        public int h_ini { get; set; }
        public int h_fim { get; set; }
        //------------

        //caracteristicas calculadas (leitura)
        public int oee { get; set; }
        public int per { get; set; }
        public int q { get; set; }
        public int dis { get; set; }
        public int cont_ini { get; set; }
        public int cont_fim { get; set; }
        public int vel_atu { get; set; }
        //caracteristicas (escritas)
        public int vel_esp { get; set; }
        public int buffer { get; set; }
        public int forma { get; set; }
        public int t_p_prog { get; set; }
        //-------------------------------
        public int t_par { get; set; }
        public int t_prod { get; set; }
        //------------------------------

        public List<Hist> historico { get; set; } = new List<Hist>();
        public List<Hist> histFiltro { get; set; } = new List<Hist>();

        public DateTime filtro_Ini { get; set; }
        public DateTime filtro_fim { get; set; }

        #region zeizz
        public int parado_sts{get;set;}
        public int rodando_sts { get; set; }
        public int espera_sts { get; set; }
        public int falha_sts { get; set; }
        public int parado_t { get; set; }
        public int rodando_t { get; set; }
        public int espera_t { get; set; }
        public int falha_t { get; set; }
        public int parado_per { get; set; }
        public int rodando_per { get; set; }
        public int espera_per { get; set; }
        public int falha_per { get; set; }
        #endregion

        //contrutores
        public Linha()
        {
            
        }

        //extras
        public string nome { get; set; }
        public string Estado { get; set; }


        //acoes

        #region zeizz
        public void leituraStatus(int[] values)
        {
            falha_sts = values[0];
            espera_sts = values[1];
            rodando_sts = values[2];
            parado_sts = values[3];
            
            if (values[0] == -1) { Estado = "DXM OffLine"; }
        }
        public void leituratimes(int[] values)
        {
            falha_t = values[0];
            espera_t = values[1];
            rodando_t = values[2];
            parado_t = values[3];
            
            
           
        }
        public void leituraPercent(int[] values)
        {
            falha_per = values[0];
            espera_per = values[1];
            rodando_per = values[2];
            parado_per = values[3];           
            
        }

        #endregion

        public void insert_dinamics(int[] values)
        {
            cont_in = values[0];
            cont_out = values[1];
            maq_sts = Convert.ToBoolean(values[2]);           

            if (values[2] == 100) {
                Estado = "Estação OffLine";
                oee = -1;           
            }
            else if (maq_sts) { Estado = "Parada"; }
            else { Estado = "Operando"; }
        }

        public void insert_calculadas(int[] values)
        {
            oee = values[0];
            per = values[1];
            q = values[2];
            dis = values[3];
            cont_ini = values[4];
            cont_fim = values[5];
            vel_atu = values[6];
            vel_esp = values[7];
            buffer = values[8];
            forma  = values[9];
            t_p_prog = values[10];
            t_par = values[11];
            t_prod = values[12];
            if (values[0] == -1) { Estado = "DXM OffLine"; }
        }
        public void insert_falha()
        {
            cont_in = -1;
            cont_out = -1;
            maq_sts = false;
            h_ini = -1;
            h_fim = -1;
            oee = -1;
            per = -1;
            dis = -1;
            q = -1;
            cont_ini = -1;
            cont_fim = -1;
            vel_atu = -1;
            //vel_esp = -1;
            //buffer = -1;
            //forma = -1;
            //t_p_prog = -1;
            t_par = -1;
            t_prod = -1;

            parado_sts = -1;
            rodando_sts = -1;
            espera_sts = -1;
            falha_sts = -1;

            Estado = "DXM OffLine";
        }

        public void exect_log()
        {
           // Hist log = new Hist(cont,oee,dis,q,per,cont_in);
            //historico.Add(log);
            //cont++;


        }

        public string get_log_time(bool filtro)            
        {
            string ret = "";
            if (!filtro)
            {                
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("\'{0} {1}\'", historico[x].time.ToShortDateString(), historico[x].time.ToShortTimeString());
                    }
                    else
                    {
                        ret = ret + string.Format("\'{0} {1}\',", historico[x].time.ToShortDateString(), historico[x].time.ToShortTimeString());
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == histFiltro.Count - 1)
                    {
                        ret = ret + string.Format("\'{0} {1}\'", histFiltro[x].time.ToShortDateString(), histFiltro[x].time.ToShortTimeString());
                    }
                    else
                    {
                        ret = ret + string.Format("\'{0} {1}\',", histFiltro[x].time.ToShortDateString(), histFiltro[x].time.ToShortTimeString());
                    }
                }
            }
            return ret;

        }

        public string get_log_oee(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}",historico[x].oee);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},",historico[x].oee);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].oee);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].oee);
                    }
                }
            }

            return ret;
        }

        public string get_log_dis(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].dis);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].dis);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].dis);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].dis);
                    }
                }
            }

            return ret;
        }

        public string get_log_q(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].q);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].q);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].q);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].q);
                    }
                }
            }

            return ret;
        }

        public string get_log_per(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].per);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].per);
                    }
                }
            }

            return ret;
        }

        public string get_log_parado(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].parado_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].parado_per);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].parado_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].parado_per);
                    }
                }
            }

            return ret;
        }

        public string get_log_rodando(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].rodando_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].rodando_per);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].rodando_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].rodando_per);
                    }
                }
            }

            return ret;
        }

        public string get_log_espera(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].espera_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].espera_per);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].espera_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].espera_per);
                    }
                }
            }

            return ret;
        }

        public string get_log_falha(bool filtro)
        {
            string ret = "";
            if (!filtro)
            {
                for (int x = 0; x < historico.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", historico[x].falha_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", historico[x].falha_per);
                    }
                }
            }
            else
            {
                for (int x = 0; x < histFiltro.Count; x++)
                {
                    if (x == historico.Count - 1)
                    {
                        ret = ret + string.Format("{0}", histFiltro[x].falha_per);
                    }
                    else
                    {
                        ret = ret + string.Format("{0},", histFiltro[x].falha_per);
                    }
                }
            }

            return ret;
        }

        public void setFiltro(DateTime ini,DateTime fim)
        {
            filtro_Ini = ini;
            filtro_fim = fim;

            List<Hist> temp = new List<Hist>();
            for(int x = 0; x < historico.Count; x++)
            {
                if(historico[x].time >= ini && historico[x].time<= fim)
                {
                    temp.Add(historico[x]);
                }
            }

            histFiltro = temp;
        }
    }
}
