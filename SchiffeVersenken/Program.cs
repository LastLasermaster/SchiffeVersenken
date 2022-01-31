using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchiffeVersenken {
    public class SchiffeVersenken {

        private Zelle[,] spielfeldSpieler1;
        private Zelle[,] spielfeldSpieler2;

        public SchiffeVersenken() {
            spielfeldSpieler1 = new Zelle[10, 10];
            spielfeldSpieler2 = new Zelle[10, 10];

            for (int i = 0; i < spielfeldSpieler1.GetLength(0); i++) {
                for (int j = 0; j < spielfeldSpieler2.GetLength(1); j++) {
                    spielfeldSpieler1[i, j] = Zelle.unbesetzt;
                    spielfeldSpieler2[i, j] = Zelle.unbesetzt;
                }
            }
        }

        static void Main(string[] args) {
        }

        private class Schiffe {

        }
    }

    enum Zelle {
        unbesetzt = 0,
        schiff = 1,
        getroffen = 3
    }
}
