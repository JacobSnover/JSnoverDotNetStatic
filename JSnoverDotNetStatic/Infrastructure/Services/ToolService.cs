﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JSnoverDotNetStatic.Models;

namespace JSnoverDotNetStatic.Infrastructure.Services
{
    public class ToolService
    {
        /// <summary>
        /// counts new visitor, also checks if new visitor count is divisible by 100
        /// </summary>
        /// <returns></returns>
        public async Task CountVisitor()
        {
            try
            {
                //db = new jsnoverdotnetdbContext();
                //var tempList = db.VisitorCounter.ToArray();
                //var tempCount = tempList.FirstOrDefault();
                //tempCount.VisitorCount = tempCount?.VisitorCount + 1;
                //db.VisitorCounter.Update(tempCount);
                //await db.SaveChangesAsync();

                //if (tempCount.VisitorCount % 100 == 0)
                //{
                //    var hundoCount = tempList.LastOrDefault();
                //    db.VisitorCounter.Add(new VisitorCounter
                //    {
                //        Id = 0,
                //        VisitorCount = tempCount.VisitorCount,
                //        VisitorCountHundreds = hundoCount.VisitorCountHundreds + 1,
                //        VisitorDate = DateTime.Now
                //    });
                //    await db.SaveChangesAsync();
                //}
            }
            catch (Exception)
            {

            }
        }
    }
}
