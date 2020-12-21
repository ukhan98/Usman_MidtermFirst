using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Usman_MidtermFirst.Models
{
    public class Repository
    {
        private static List<Workshop> _workshops;
        static Repository()
        {
            _workshops = initWorkshops();
        }

        public static IEnumerable<Workshop> getRepo()
        {
            return _workshops;
        }

        public static void Enroll(int workShopId, Enrollment enrollment)
        {
            foreach (var workShop in _workshops)
            {
                //this is better but not required
                //if (workShop.Id == workShopId && !workShop.IsFull)
                if (workShop.Id == workShopId)
                {
                    workShop.Enrollments.Add(enrollment);
                }
            }
            
        }
        private static List<Workshop> initWorkshops()
        {
            List<Enrollment> EnrollmentList1 = new List<Enrollment>
            {
                new Enrollment
                {
                    Name = "Mike",
                    Email = "Ajaj@sheridancollege.ca"
                }
            };
            List<Enrollment> EnrollmentList2 = new List<Enrollment>
            {
                new Enrollment
                {
                    Name = "sam",
                    Email = "sam@sheridancollege.ca"
                },
                new Enrollment
                {
                    Name = "jam",
                    Email = "jam@sheridancollege.ca"
                },
            };
            List<Enrollment> EnrollmentList3 = new List<Enrollment>();
            for (int i = 0; i < 10; i++)
            {
                EnrollmentList3.Add(
                    new Enrollment
                {
                    Name = $"{i}",
                    Email = $"{i}@wow.com"
                });
            }

            Workshop workshop1 = new Workshop()
            {
                Id = 1,
                Title = "Art",
                Information = "Do Some Art",
                Capacity = 7,
                Enrollments = EnrollmentList1
            };
            Workshop workshop2 = new Workshop()
            {
                Id = 2,
                Title = "Game",
                Information = "Do Some Game",
                Capacity = 5,
                Enrollments = EnrollmentList2
            };
            Workshop workshop3 = new Workshop()
            {
                Id = 3,
                Title = "programming",
                Information = "Do Some programing in c#",
                Capacity = 10,
                Enrollments = EnrollmentList3
            };
            return new List<Workshop>() {workshop1, workshop2, workshop3};
        }
    }
}
