using AsiHackathonTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AsiHackathonTest.Controllers
{
    [Authorize]
    public class ReservationsController : ApiController
    {
        private Reservation[] Reservations = new Reservation[] {
                new Reservation
                {
                    Id = 0,
                    ReservedTime = DateTime.Today - TimeSpan.FromDays(1),
                    Name = "Table A",
                    IsReserved = false,
                    Timestamp = DateTime.Now,
                    X = 0,
                    Y = 0,
                    W = 1,
                    H = 1
                },

                new Reservation
                {
                    Id = 1,
                    ReservedTime = DateTime.Today - TimeSpan.FromDays(1) + TimeSpan.FromHours(8),
                    Name = "Table B",
                    IsReserved = false,
                    Timestamp = DateTime.Now,
                    X = 5,
                    Y = 0,
                    W = 3,
                    H = 1
                },

                new Reservation
                {
                    Id = 2,
                    ReservedTime = DateTime.Today - TimeSpan.FromDays(2),
                    Name = "Table C",
                    IsReserved = false,
                    Timestamp = DateTime.Now,
                    X = 2,
                    Y = 2,
                    W = 2,
                    H = 1
                }
            };

        // GET api/values
        public IEnumerable<Reservation> Get()
        {
            return Reservations;
        }

        // GET api/values/5
        public Reservation Get(int id)
        {
            if (id >= 0 && id < Reservations.Length)
            {
                return Reservations[id];
            }
            else return null;

        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        
        // PUT api/values/5
        /// <summary>
        /// Add a table
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string name, [FromBody]int x, [FromBody]int y)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// Remove a table
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
        
    }
}
