using Mono.Options;
using System.Diagnostics;

namespace TestOptions {
    class Program {
        static private string sa;
        static protected string sb;
        static string sc;
        static public string sd;

        private string a;
        protected string b;
        string c;
        public string d;

        static void Main(string[] args) {
            Program app = new Program();

            Debug.WriteLine("--- args ---");
            Debug.WriteLine("a: " + args[1]);
            Debug.WriteLine("b: " + args[3]);
            Debug.WriteLine("c: " + args[5]);
            Debug.WriteLine("d: " + args[7]);

            var o = new OptionSet() {
                { "a=", "aaa", v => { app.a = v; sa = v;} },
                { "b=", "bbb", v => { app.b = v; sb = v;} },
                { "c=", "ccc", v => { app.c = v; sc = v;} },
                { "d=", "ddd", v => { app.d = v; sd = v;} },
            };
            var opts = o.Parse(args);

            app.showVars();

            Debug.WriteLine("--- statics vars ---");
            Debug.WriteLine("sa: " + sa);
            Debug.WriteLine("sb: " + sb);
            Debug.WriteLine("sc: " + sc);
            Debug.WriteLine("sd: " + sd);
        }

        protected void showVars() {
            Debug.WriteLine("--- instance vars ---");
            Debug.WriteLine("a: " + a);
            Debug.WriteLine("b: " + b);
            Debug.WriteLine("c: " + c);
            Debug.WriteLine("d: " + d);
        }

    }
}
