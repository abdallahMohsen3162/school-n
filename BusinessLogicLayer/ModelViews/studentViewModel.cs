﻿

using DataAccessLayer.Models;


namespace BusinessLogicLayer.ModelViews
{
    public class studentViewModel
    {

        public Student student { get; set; } = new Student();

        public IEnumerable<Course>? taken { get; set; }
        public IEnumerable<Course>? notTaken { get; set; }

    }
}
