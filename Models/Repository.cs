using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace study.Models
{
    public class Repository
    {
        private static List<GuestResponce> responses = new List<GuestResponce>();
        public static IEnumerable<GuestResponce> Responses {
            get {
                return responses;
            }
        }

        public static void AddResponse(GuestResponce responce) {
            responses.Add(responce);
        }
        
    }
}