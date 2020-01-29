using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXM.OEE
{
    public class Hist
    {
        public int id { get; set; }
        public DateTime time { get; set; }
        public int oee { get; set; }
        public int dis { get; set; }
        public int q { get; set; }
        public int per { get; set; }

        public int produzido { get; set; }

        #region ziess

        public int parado_t { get; set; }
        public int rodando_t { get; set; }
        public int espera_t { get; set; }
        public int falha_t { get; set; }
        public int parado_per { get; set; }
        public int rodando_per { get; set; }
        public int espera_per { get; set; }
        public int falha_per { get; set; }

        #endregion

        public Hist()
        {

        }
        public Hist(int _id,int _oee,int _dis, int _q,int _per, int _produzido)
        {
            time = DateTime.Now.ToLocalTime();
            oee = _oee;
            dis = _dis;
            q = _q;
            per = _per;
            produzido = _produzido;
            id = _id;

        }
        public Hist(int _oee, int _dis, int _q, int _per, int _produzido)
        {
            time = DateTime.Now.ToLocalTime();
            oee = _oee;
            dis = _dis;
            q = _q;
            per = _per;
            produzido = _produzido;
            id = 0;
        }

        public Hist(int _parado,int _rodando,int _espera,int _falha,int _para_per,int _roda_per,int _espe_per,int _falha_per)
        {
            time = DateTime.Now.ToLocalTime();
            parado_t = _parado;
            rodando_t = _rodando;
            espera_t = _espera;
            falha_t = _falha;
            parado_per = _para_per;
            rodando_per = _roda_per;
            espera_per = _espe_per;
            falha_per = _falha_per;

        }
    }
}
