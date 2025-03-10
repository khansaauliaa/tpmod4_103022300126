using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace tpmod4_1030223300126
{
    class KodePos
    {
        public static string getKodePos(string daerah)
        {
            string[,] datakodePos = {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" },
            { "Samoja", "40273" }
        };

            for (int i = 0; i < datakodePos.GetLength(0); i++)
                if (datakodePos[i, 0].Equals(daerah, StringComparison.OrdinalIgnoreCase))
                    return datakodePos[i, 1];
            return "kode pos tidak ditemukan";

        }

        internal int GetKodePos(string input)
        {
            throw new NotImplementedException();
        }
    }
}