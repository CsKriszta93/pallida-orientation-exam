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

        public LicencePlateClass GetLicencePlate(string licenceplate)
        {
            var selected = (from plate in LicencePlateContext.licence_plates
                            where plate.plate.Contains(licenceplate)
                            select plate).FirstOrDefault();
            return selected;
        }
    }
}
