using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;
public class UserImage : BaseEntity<Guid>
{
    public int UserId { get; set; }
    public string ImagePath { get; set; }


    public virtual User User { get; set; }

    public UserImage()
    {

    }

    public UserImage(Guid id, int userId, string imagePath) : this()
    {
        Id = id;
        UserId = userId;
        ImagePath = imagePath;
    }
}


