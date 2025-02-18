﻿using Microsoft.EntityFrameworkCore;
using Project_X.Database;
using Project_X.Models;
using Project_X.Repositories.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Project_X.Repositories.Implementations
{
    public class OfferRepository : IOfferRepository
    {
        private readonly AppDbContext _appDbContext;

        public OfferRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Offer>> GetOffers()
        {
            return await _appDbContext.Offers.ToListAsync();
        }

        public async Task<Offer> GetOfferById(long id)
        {
            return await _appDbContext.Offers.FindAsync(id);
        }

        public async Task<bool> AddOffer(Offer offer)
        {
            await _appDbContext.Offers.AddAsync(offer);
            int added = await _appDbContext.SaveChangesAsync();
            return added > 0;
        }

        public async Task<bool> UpdateOffer(Offer offer)
        {
            _appDbContext.Offers.Update(offer);
            int updated = await _appDbContext.SaveChangesAsync();
            return updated > 0;
        }

        public async Task<bool> DeleteOffer(long id)
        {
            Offer offer = await _appDbContext.Offers.FindAsync(id);
            _appDbContext.Offers.Remove(offer);
            int deleted = await _appDbContext.SaveChangesAsync();
            return deleted > 0;
        }
    }
}
