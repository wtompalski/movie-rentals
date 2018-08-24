using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BooksController : ODataController
    {


        public BooksController()
        {
            
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(DataSource.GetBooks());
        }

        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(null);
        }

        [EnableQuery]
        public IActionResult Post([FromBody]Book book)
        {
            return null;
        }

        [EnableQuery]
        public IActionResult Delete([FromBody]int key)
        {
            return null;
        }
    }
}
