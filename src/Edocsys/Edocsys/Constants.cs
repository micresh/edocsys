using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edocsys
{
    static class Constants
    {
        //Статусы/этапы выполнения работ
        public enum ContractStatuses : int
        {
            NewProposal = 0,                    // (0,'Создание заявки')
            ExpertAssigment = 1,                // (1,'Закрепление эксперта')
            ContractConfirm = 2,                // (2,'Заключение договора') - заключение договора/установка суммы
            PreparationsForTask = 3,            // (3,'Подготовка к работе') - получение образцов/акт списания образцов
            InWork = 4,                         // (4,'В работе')  - оплата/проверка дат
            ComplitionManagerConfrim = 5,       // (5,'Подтверждение выполнения руководителем') - оплата/подтверждение выполнения
            ComplitionAgentConfrim = 6,         // (6,'Подтверждение выполнения клиентом') - выдача сертификата/выдача акт выполнения клиенту на подпись
            ReattestationSign = 7,              // (7,'Заключение договора реаттестации') - подписание акта руководителем/доп. соглашение/установка сроков ресертификации
            InspectionControl = 8,              // (8,'Договора на инспекционном контроле') - генерация док-ов о прохождении контроля
            FinishedTasks = 9,                  // (9,'Завершенные договора')

            BadJobByAgent = 20,                 // (20,'Невыполнение по вине заказчика')
            BadJobByExpert = 21,                // (21,'Невыполнение по вине эксперта')
        }

        //Типы договоров/документов
        public enum ContractTypes : int
        {
            //Общие документы
            Proposal = 0,                       // (0, 'Заявка')
            Act = 1,                            // (1, 'Акт выполненных работ')
            Reattestation1 = 2,                 // (2, 'Документ о первом инспекционном контроле/реаттестация')
            Reattestation2 = 3,                 // (3, 'Документ о втором инспекционном контроле/реаттестация')
            //Resertification = 4,                // (4, 'Документ о первом инспекционном контроле')
            //Документы для договора
            Sertefication = 10,                 // (10, 'Сертификация')
            SerteficationWithDeclaration = 11,  // (11, 'Сертификация с декларацией')
            LabIssues = 12,                     // (12, 'Лабораторные исследования')
            LabIssuesWithSertefication = 13,    // (13, 'Лабораторные исследования с сертификацией')
        }

        public enum UserTypes : int
        {
            Admin = 1, 
            Expert = 2,
            Director = 3,
        }

        public enum SourceTypes : int
        {
            Personal = 1,
            Phone = 2,
            Internet = 3,
        }
    }
}
