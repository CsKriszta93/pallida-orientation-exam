using LicencePlate.Entities;
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
    }
}
