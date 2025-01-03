﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalWalletManagement.BusinessLayer.ViewModels
{
    public class PaymentViewModel
    {
        public int ScheduleId { get; set; }
        public int WalletId { get; set; }
        public decimal Amount { get; set; }
        public int RecipientId { get; set; }
        public string Frequency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
