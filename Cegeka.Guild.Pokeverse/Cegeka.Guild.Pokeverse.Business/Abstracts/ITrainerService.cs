﻿using System.Collections.Generic;
using Cegeka.Guild.Pokeverse.Business.Models;

namespace Cegeka.Guild.Pokeverse.Business.Abstracts
{
    public interface ITrainerService
    {
        IEnumerable<TrainerModel> GetAll();

        void Register(string name);
    }
}