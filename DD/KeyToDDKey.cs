using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlwysClick
{
    public class KeyToDDKey
    {
        Dictionary<Keys, int> _Dic = new Dictionary<Keys, int>();
        public  Dictionary<Keys, int> Dic
        {
            get
            {
                if (_Dic.Keys.Count == 0)
                {
                    _Dic.Add(Keys.Escape, 100);
                    _Dic.Add(Keys.F1, 101);
                    _Dic.Add(Keys.F2, 102);
                    _Dic.Add(Keys.F3, 103);
                    _Dic.Add(Keys.F4, 104);
                    _Dic.Add(Keys.F5, 105);
                    _Dic.Add(Keys.F6, 106);
                    _Dic.Add(Keys.F7, 107);
                    _Dic.Add(Keys.F8, 108);
                    _Dic.Add(Keys.F9, 109);
                    _Dic.Add(Keys.F10, 110);
                    _Dic.Add(Keys.F11, 111);
                    _Dic.Add(Keys.F12, 112);

                    _Dic.Add(Keys.D1, 201);
                    _Dic.Add(Keys.D2, 202);
                    _Dic.Add(Keys.D3, 203);
                    _Dic.Add(Keys.D4, 204);
                    _Dic.Add(Keys.D5, 205);
                    _Dic.Add(Keys.D6, 206);
                    _Dic.Add(Keys.D7, 207);
                    _Dic.Add(Keys.D8, 208);
                    _Dic.Add(Keys.D9, 209);
                    _Dic.Add(Keys.D0, 210);

                    _Dic.Add(Keys.Tab, 300);
                    _Dic.Add(Keys.Q, 301);
                    _Dic.Add(Keys.W, 302);
                    _Dic.Add(Keys.E, 303);
                    _Dic.Add(Keys.R, 304);
                    _Dic.Add(Keys.T, 305);
                    _Dic.Add(Keys.Y, 306);
                    _Dic.Add(Keys.U, 307);
                    _Dic.Add(Keys.I, 308); 
                    _Dic.Add(Keys.O, 309);
                    _Dic.Add(Keys.P, 310);

                    _Dic.Add(Keys.A, 401);
                    _Dic.Add(Keys.S, 402);
                    _Dic.Add(Keys.D, 403);
                    _Dic.Add(Keys.F, 404);
                    _Dic.Add(Keys.G, 405);
                    _Dic.Add(Keys.H, 406);
                    _Dic.Add(Keys.J, 407);
                    _Dic.Add(Keys.K, 408);
                    _Dic.Add(Keys.L, 409);

                    _Dic.Add(Keys.Z, 501);
                    _Dic.Add(Keys.X, 502);
                    _Dic.Add(Keys.C, 503);
                    _Dic.Add(Keys.V, 504);
                    _Dic.Add(Keys.B, 505);
                    _Dic.Add(Keys.N, 506);
                    _Dic.Add(Keys.M, 507);

                }

                return _Dic;
            }
        }











    }
}
