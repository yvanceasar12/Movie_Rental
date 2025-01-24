﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie_Rental.Data;
using Movie_Rental.Models;

namespace Movie_Rental.Controllers
{
  
        [Route("api/[controller]")]
        [ApiController]
        public class CustomerController : ControllerBase
        {
            private readonly AppDbContext _context;

            public CustomerController(AppDbContext context)
            {
                _context = context;
            }

            // GET: api/Customers
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
            {
                return await _context.Customers.ToListAsync();
            }

            // GET: api/Customers/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Customer>> GetCustomer(int id)
            {
                var customer = await _context.Customers.FindAsync(id);

                if (customer == null)
                {
                    return NotFound();
                }

                return customer;
            }

            // POST: api/Customers
            [HttpPost]
            public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
            {
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
            }

            // PUT: api/Customers/5
            [HttpPut("{id}")]
            public async Task<IActionResult> PutCustomer(int id, Customer customer)
            {
                if (id != customer.Id)
                {
                    return BadRequest();
                }

                _context.Entry(customer).State = EntityState.Modified;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            // DELETE: api/Customers/5
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCustomer(int id)
            {
                var customer = await _context.Customers.FindAsync(id);
                if (customer == null)
                {
                    return NotFound();
                }

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();

                return NoContent();
            }
        }
}

