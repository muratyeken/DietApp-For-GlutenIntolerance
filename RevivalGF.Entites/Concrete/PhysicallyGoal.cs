﻿using RevivalGF.Entites.Abstract;
using RevivalGF.Entites.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevivalGF.Entites.Concrete
{
    public class PhysicallyGoal : IPhysicallyGoal, IBaseEntity
    {
        [Key]
        public int GoalID { get; set; }
        public TargetedDiet TargetedDiet { get; set; }
        public ActivityStatus ActivityStatus { get; set; }
        public decimal DietCalorieControl { get; set; }
        public List<User> Users { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string CreatedBy { get; set; }
        public string DeletedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
    }
}