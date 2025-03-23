﻿using Piece_of_Art_Mall.DTOs.LoyalityCardDTOs;
using Piece_of_Art_Mall.Resposes;

namespace Piece_of_Art_Mall.Repository_Pattern.LoyalityCard_Repository
{
    public interface ILoyalityCard
    {
        public AddResponse AddLoyality(LoyalityOnly loyality);
        public AddResponse AddLoyality(LoyalityWithCustomer loyality);


    }
}
