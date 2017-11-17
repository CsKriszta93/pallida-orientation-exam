using LicencePlate.Entities;
using LicencePlate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LicencePlate.Repositories
{
    public class LicencePlateRepository
    {
        LicencePlateContext LicencePlateContext;

        public LicencePlateRepository(LicencePlateContext licencePlateContext)
        {
            LicencePlateContext = licencePlateContext;
        }

        public List<LicencePlateClass> LicencePlateList()
        {
            return LicencePlateContext.licence_plates.ToList();
        }

        public LicencePlateClass GetById(long id)
        {
            var plate = LicencePlateContext.licence_plates.FirstOrDefault(p => p.Id == id);
            return plate;
        }

        public List<LicencePlateClass> GetLicencePlate(string licenceplate)
        {
            var selected = from plate in LicencePlateContext.licence_plates
                           where plate.plate.Contains(licenceplate)
                           select plate;
            return selected.ToList();
        }

        public List<LicencePlateClass> OnlyPoliceCars()
        {
            var policeCars = from plate in LicencePlateContext.licence_plates
                             where plate.plate.StartsWith("RB")
                             select plate;
            return policeCars.ToList();
        }

        public List<LicencePlateClass> OnlyDiplomats()
        {
            var diplomatCars = from plate in LicencePlateContext.licence_plates
                               where plate.plate.StartsWith("DT")
                               select plate;
            return diplomatCars.ToList();
        }
    }
}
