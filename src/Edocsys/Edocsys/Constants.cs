using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edocsys
{
    static class Constants
    {
        public enum ContractTypes : int
        {
            NewProposal = 0,            // (0,'Заявка добавлена')
            WaitForExpertAssigment = 1, // (1,'Ожидание прикрепления эксперта')
            ExpertAssigned = 2,         // (2,'К заявке прикреплен эксперт')
            TaskProcessed = 3,          // (3,'Начата работа по заявке')
            TaskReady = 4,              // (4,'Оформлен акт выполненных работ')
            TaskFinished = 5,           // (5,'Акт утвержден руководителем')

            BadJobByAgent = 20,         // (20,'Невыполнение по вине заказчика')
            BadJobByExpert = 21,        // (21,'Невыполнение по вине эксперта')
        }
    }
}
