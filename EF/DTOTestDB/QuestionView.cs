﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.DTOTestDB
{
    class QuestionView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
    }
}