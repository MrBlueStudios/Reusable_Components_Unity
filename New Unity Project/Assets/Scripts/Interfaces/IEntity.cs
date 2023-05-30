﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Entity.Base
{
    internal interface IEntity
    {
        protected void Initialize();
        protected void Update();

    }
}
