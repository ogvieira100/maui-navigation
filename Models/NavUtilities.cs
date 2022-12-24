
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maui_navigation.Models
{
    public class NavUtilities
    {

        public static void InsertPage(INavigation navigation, Page pageBefore)
        {
            var secondPage =
                 navigation.NavigationStack
                 .ElementAtOrDefault(1);
            if (secondPage != null)
            {
                navigation.InsertPageBefore(pageBefore,
                     secondPage);
            }
        }

        public static void DeletePage(INavigation navigation, string pageName)
        {
            var pageToDelete =
                 navigation.NavigationStack
                 .FirstOrDefault(x => x.GetType().Name == pageName);
            if (pageToDelete != null)
            {
                navigation.RemovePage(pageToDelete);
            }
        }

        public static void Examine(INavigation navigation)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in navigation.NavigationStack)
            {
                sb.Append(item.GetType().Name.ToString()+" ");

            }
            sb.AppendLine("_____________________");
            Debug.WriteLine(sb.ToString());
        }
    }
}
