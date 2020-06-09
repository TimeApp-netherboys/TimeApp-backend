﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TimeApp.Model.Response;

namespace TimeApp.Service
{
    public interface IProjectService
    {

        Task<List<ProjectDTO>> GetAllProjectsTotal();
    }
}
