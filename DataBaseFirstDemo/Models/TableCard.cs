﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DataBaseFirstDemo.Models;

public partial class TableCard
{
    public int Id { get; set; }

    public int CardTypeId { get; set; }

    public int CardGroupId { get; set; }

    public string Code { get; set; }

    public bool IsUsed { get; set; }

    public bool IsLost { get; set; }

    public bool IsDamaged { get; set; }

    public int Reason { get; set; }

    public string Note { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsActive { get; set; }

    public string CreatedBy { get; set; }

    public string ModifiedBy { get; set; }
}