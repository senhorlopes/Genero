using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    public class Genero
    {
        public bool NomeEhMasculino(string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return true;

            var primeiroNome = nome.Split(' ')[0];
            if (string.IsNullOrEmpty(primeiroNome))
                return true;


            return EhMasculino(primeiroNome);
        }
        public bool NomeEhFeminino(string nome)
        {
            return !NomeEhMasculino(nome);
        }
             
        private bool EhMasculino(string primeiroNome)
        {
            char[] chars = primeiroNome.ToLower().ToCharArray();
            Array.Reverse(chars);
            var nomeInvertido = (new String(chars)).Trim();

            var caracter = nomeInvertido.Substring(0, 1).ToCharArray();
            nomeInvertido = nomeInvertido.Substring(1) + "|";
            Regra regra = null;
            regras.TryGetValue(caracter[0], out regra);
            if (regra == null)
                return true;

            var homem = regra.Homem;            
            if (Match(nomeInvertido, regra.Exception))
                homem = !homem;
            return homem;
        }

        private bool Match(string nome, string regra)
        {
            var tempnome = nome;
            while (!string.IsNullOrEmpty(tempnome))
            {
                if (regra.IndexOf(" " + tempnome + " ") > 0)
                    return true;
                tempnome = tempnome.Substring(0, tempnome.Length - 1);
            }
            return false;
        }

        private Dictionary<char, Regra> regras = new Dictionary<char, Regra>()
        {
            {
                'a',
                new Regra()
                {
                    Exception = " bliw br civ clim diem dnar du err fa h| hc ho hpa htan ile| iledr imer ja jr ka kk la| lg lit liv loc lro man may mini mlaj mn mru muz ng nnat np om raj rat raug rieb riev " +
                    " rik riu rp ruj rum rut sa ssa ssu tai| tano tari tel terp toj tsi ua ud uh uq va vd vi| vlis vo vr w yan zuo ",
                    Homem = false
                }
                
            },
            {
                'b',
                new Regra()
                {
                    Exception = " adani ",
                    Homem = true
                }
            },
            {
                'c',
                new Regra()
                {
                    Exception = " il it ",
                    Homem = true
                }
            },
            {
                'd',
                new Regra()
                {
                    Exception = "  ade ir ",
                    Homem = true
                }
            },
            {
                'e',
                new Regra()
                {
                    Exception = " ad aj ak bao bu cal ced cilef ciru cn curb dad deb di| dia| diat dic " +
                    " dila div dla dlih dlinesa dn do el g| ge go gr gu hp ib ile ill in j " +
                    " ke ki klo kn ko ks ku lat lau lav lc ledr leg leit len less leu lh " +
                    " libat lil lir lled lo ly ma mea med mi ml mr ms mu my nahp nan navi " +
                    " navla navle navlig navo ned neico neit nelig nelsu ner| niav niaw " +
                    " nidla nidu nim nin nio nitr nnav nner nnh nnoi noc nod noe nof noice " +
                    " noicla noide noih noj nor not nr nu oi on pe pi po pp py ras rb rd reb " +
                    " red rf ria rih ro rr rt sd se sieg sliw soj sr sse ssu su tea tedlaw " +
                    " tedoi teds teia tesin teze tezin tided tiu tl tna tne tra treal treh " +
                    " trei tser ua ug uo uqa uqe uqia uqini uqir uql uqo uqr use uso uzo " +
                    " vat vi vo w y z| za ze zu ",
                    Homem = false

                }
            },
            {
                'f',
                new Regra()
                {
                    Exception = "$$$",
                    Homem = true
                }
            },
            {
                'g',
                new Regra()
                {
                    Exception = " ie neh nipm nob nuj ",
                    Homem = true
                }
            },
            {
                'h',
                new Regra()
                {
                    Exception = " ak an ar s teb ter tes tezil tezir tide| tidu tur ",
                    Homem = true
                }
            },
            {
                'i',
                new Regra()
                {
                    Exception = "  ale ana ano ba cajd calg caram cari| carid carol cedli cen| cia " +
                    " cira cle| cn co cu dak diel dir duh elrih elris em| enir ha j| ki kusi " +
                    " kuy| lag lar legn lei lek lel len les leu lev lez li lleh llek lra " +
                    " lrednaw mah mei meo mor mt muss muy muz nab nai nari nas nat naul nav| " +
                    " navi| navli nay ne| nec neg nel neru neso| nev nez nic nie nil nnej " +
                    " nom nu ram rev rh roa ruya sl sr sseg tor ts tter tteu ua vai z| zaz zus ",
                    Homem = true
                }
            },
            {
                'j',
                new Regra()
                {
                    Exception = "$$$",
                    Homem = true

                }
            },
            {
                'k',
               new Regra()
                {
                    Exception =  " an l ",
                    Homem = true
               }

            },
            {
                'l',
                new Regra()
                {
                    Exception = " am eb| ebam ebar ebas ebaz ehca eht euq iag inel lem o ",
                    Homem = true
                }
            },
            {
                'm',
                new Regra()
                {
                    Exception = " ailil air aiv arim ee eleu em er ailil| ",
                    Homem = true
                }
            },
            {
                'n',
                new Regra()
                {
                    Exception = " ailil aillil airam airi airy aivi ale alir asu avin avira ayri azu " +
                    " eho ekc ele ell em era ets ielr ilek ilev ims ir itsi itsr na| ny orah uk us y ailil| ",
                    Homem = true
                }
            },
            {
                'o',
                new Regra()
                {
                    Exception = " acie ce cim cit d| h| ico ka ke kiek kies kihc kihs kika kiku kim " +
                    " kir kit ko kur kus kuy kuzi leu nats niruam rro tej tnem ul ",
                    Homem = true
                }
            },
            {
                'p',
                new Regra()
                {
                    Exception = " iy ",
                    Homem = true
                }
            },
            {
                'r',
                new Regra()
                {
                    Exception = " al amal amaz amicy amidi amidue amilo amisl amizl amsire anide effi " +
                    " efi ehta ehts epse etse| iadam ialce ialo ian| icalg idan| idel " +
                    " inav| inave| inec| inele inez inoi oif onoe ycar ",
                    Homem = true
                }
            },
            {
                's',
                new Regra()
                {
                    Exception = "adinu aitak ecr edec edio edlia edred edru eduel edui egri ekl eleg " +
                    " enele eng eni| enia enid| enir ep ered erim| erima ero even iah ial " +
                    " iat ida ila ile| ili ill ily inedl inna io ira irc| iri| irim iris irod iry isi itr iz orieh yd yni yr ",
                    Homem = true
                }
            },
            {
                't',
                 new Regra()
                {
                    Exception = " eb er ide| ig se ten ti ",
                    Homem = true
                 }
            },
            {
                'u',
                new Regra()
                {
                    Exception = " d| la rahim| s| ",
                    Homem = true
                }
            },
            {
                'v',
                new Regra()
                {
                    Exception = "$$$",
                    Homem = true
                }
            },
            {
                'w',
                new Regra()
                {
                    Exception = "$$$",
                    Homem = true
                }
            },
            {
                'x',
                new Regra()
                {
                    Exception = "$$$",
                    Homem = true
                }
            },
            {
                'y',
                new Regra()
                {
                    Exception = " am ana anoi cal cara| cari| carod cav cira clao cn cren cu dal deh " +
                    " elrih enar g ha htor lat lea lecu leg lek len les leu lev lez lia lir " +
                    " lle lram mat nai nari nas nau navl naw neg nel neu nna nom ram remi rems " +
                    " ri ror si so su t llimac| niale| ",
                    Homem = true
                }
            },
            {
                'z',
                new Regra()
                {
                    Exception = " eni| enir ered il ir u ",
                    Homem = true
                }
            }
        };
    }

    internal class Regra
    {
        public string Exception { get; set; }
        public bool Homem { get; set; }
    }
}
