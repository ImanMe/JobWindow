﻿namespace JobBoard.Core.DTOs
{
    public class JobBoardDto
    {
        public int Id { get; set; }

        public string JobBoardName { get; set; }

        public bool IsOnlineApply { get; set; }

        public bool IsEmailApply { get; set; }
    }
}
