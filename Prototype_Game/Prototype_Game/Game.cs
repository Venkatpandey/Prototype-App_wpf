using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Prototype_Game
{

    public class Game
    {

        LoadDictionary dictLoader = new LoadDictionary();

        public string getReply(string userWord)
        {

            char lastAlphabet = userWord[userWord.Length - 1];
            string pickedWord = wordPicker(lastAlphabet);
            return pickedWord;
        }

        public string gameInitiator()
        {
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            Random r = new Random();
            int i = r.Next(chars.Length);
            char randChar = chars[i];
            string rWord = wordPicker(randChar);
            return rWord;
        }

        private string wordPicker(char lastAlpha)
        {
            // dictionary initialization

            Random randNumber = new Random();
            string returnWord = null;

            switch (lastAlpha)
            {
                case 'a':
                    List<string> aletters = dictLoader.aEntries();
                    int randPositionA = randNumber.Next(aletters.Count);
                    returnWord = aletters[randPositionA];
                    break;

                case 'b':
                    List<string> bletters = dictLoader.bEntries();
                    int randPositionB = randNumber.Next(bletters.Count);
                    returnWord = bletters[randPositionB];
                    break;

                case 'c':
                    List<string> cletters = dictLoader.cEntries();
                    int randPositionC = randNumber.Next(cletters.Count);
                    returnWord = cletters[randPositionC];
                    break;

                case 'd':
                    List<string> dletters = dictLoader.dEntries();
                    int randPositionD = randNumber.Next(dletters.Count);
                    returnWord = dletters[randPositionD];
                    break;

                case 'e':
                    List<string> eletters = dictLoader.eEntries();
                    int randPositionE = randNumber.Next(eletters.Count);
                    returnWord = eletters[randPositionE];
                    break;

                case 'f':
                    List<string> fletters = dictLoader.fEntries();
                    int randPositionF = randNumber.Next(fletters.Count);
                    returnWord = fletters[randPositionF];
                    break;

                case 'g':
                    List<string> gletters = dictLoader.gEntries();
                    int randPositionG = randNumber.Next(gletters.Count);
                    returnWord = gletters[randPositionG];
                    break;

                case 'h':
                    List<string> hletters = dictLoader.hEntries();
                    int randPositionH = randNumber.Next(hletters.Count);
                    returnWord = hletters[randPositionH];
                    break;

                case 'i':
                    List<string> iletters = dictLoader.iEntries();
                    int randPositionI = randNumber.Next(iletters.Count);
                    returnWord = iletters[randPositionI];
                    break;

                case 'j':
                    List<string> jletters = dictLoader.jEntries();
                    int randPositionJ = randNumber.Next(jletters.Count);
                    returnWord = jletters[randPositionJ];
                    break;

                case 'k':
                    List<string> kletters = dictLoader.kEntries();
                    int randPositionK = randNumber.Next(kletters.Count);
                    returnWord = kletters[randPositionK];
                    break;

                case 'l':
                    List<string> lletters = dictLoader.lEntries();
                    int randPositionL = randNumber.Next(lletters.Count);
                    returnWord = lletters[randPositionL];
                    break;

                case 'm':
                    List<string> mletters = dictLoader.mEntries();
                    int randPositionM = randNumber.Next(mletters.Count);
                    returnWord = mletters[randPositionM];
                    break;

                case 'n':
                    List<string> nletters = dictLoader.nEntries();
                    int randPositionN = randNumber.Next(nletters.Count);
                    returnWord = nletters[randPositionN];
                    break;

                case 'o':
                    List<string> oletters = dictLoader.oEntries();
                    int randPositionO = randNumber.Next(oletters.Count);
                    returnWord = oletters[randPositionO];
                    break;

                case 'p':
                    List<string> pletters = dictLoader.pEntries();
                    int randPositionP = randNumber.Next(pletters.Count);
                    returnWord = pletters[randPositionP];
                    break;

                case 'q':
                    List<string> qletters = dictLoader.qEntries();
                    int randPositionQ = randNumber.Next(qletters.Count);
                    returnWord = qletters[randPositionQ];
                    break;

                case 'r':
                    List<string> rletters = dictLoader.rEntries();
                    int randPositionR = randNumber.Next(rletters.Count);
                    returnWord = rletters[randPositionR];
                    break;

                case 's':
                    List<string> sletters = dictLoader.sEntries();
                    int randPositionS = randNumber.Next(sletters.Count);
                    returnWord = sletters[randPositionS];
                    break;

                case 't':
                    List<string> tletters = dictLoader.tEntries();
                    int randPositionT = randNumber.Next(tletters.Count);
                    returnWord = tletters[randPositionT];
                    break;

                case 'u':
                    List<string> uletters = dictLoader.uEntries();
                    int randPositionU = randNumber.Next(uletters.Count);
                    returnWord = uletters[randPositionU];
                    break;

                case 'v':
                    List<string> vletters = dictLoader.vEntries();
                    int randPositionV = randNumber.Next(vletters.Count);
                    returnWord = vletters[randPositionV];
                    break;

                case 'w':
                    List<string> wletters = dictLoader.wEntries();
                    int randPositionW = randNumber.Next(wletters.Count);
                    returnWord = wletters[randPositionW];
                    break;

                case 'x':
                    List<string> xletters = dictLoader.xEntries();
                    int randPositionX = randNumber.Next(xletters.Count);
                    returnWord = xletters[randPositionX];
                    break;

                case 'y':
                    List<string> yletters = dictLoader.yEntries();
                    int randPositionY = randNumber.Next(yletters.Count);
                    returnWord = yletters[randPositionY];
                    break;

                case 'z':
                    List<string> zletters = dictLoader.zEntries();
                    int randPositionZ = randNumber.Next(zletters.Count);
                    returnWord = zletters[randPositionZ];
                    break;

                default: returnWord = "Invalid Word..!";
                    break;

            };

            return returnWord;

        }



    }
}
