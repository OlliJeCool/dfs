using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFS
{
    public class App
    {
        public void Run()
        {
            var dfs = new DFS();
            var head = dfs.Init();
            dfs.Run(head);
        }
    }
}
