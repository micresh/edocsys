using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edocsys.Helpers
{
    public static partial class DBMigrationHelper
    {
        private static Migration[] Migrations = new Migration[]
        {
#region DBMigration__01__2014_05_26
            //DBMigration #01 [2014-05-26]
            //change structure agents
            new Migration(01, 01, @"ALTER TABLE `edocbase`.`agents` CHANGE COLUMN `phone` `phone` VARCHAR(50) NULL DEFAULT NULL"),
            new Migration(01, 02, @"ALTER TABLE `edocbase`.`agents` CHANGE COLUMN `fax` `fax` VARCHAR(50) NULL DEFAULT NULL"),

            new Migration(01, 03, @"ALTER TABLE `edocbase`.`agents` CHANGE COLUMN `ks` `ks` VARCHAR(21) NULL DEFAULT NULL"),
            new Migration(01, 04, @"ALTER TABLE `edocbase`.`agents` CHANGE COLUMN `rs` `rs` VARCHAR(21) NULL DEFAULT NULL"),

            //change structure agents_contacts
            new Migration(01, 05, @"ALTER TABLE `edocbase`.`agents_contacts` CHANGE COLUMN `phone` `phone` VARCHAR(50) NULL DEFAULT NULL"),
            new Migration(01, 06, @"ALTER TABLE `edocbase`.`agents_contacts` CHANGE COLUMN `fax` `fax` VARCHAR(50) NULL DEFAULT NULL"),

            // add new data agent_types
            new Migration(01, 07, @"
                                    SET foreign_key_checks = 0;

                                    DELETE FROM `edocbase`.`agent_types` where id >= 0;

                                    INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (1, '');
                                    INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (2, 'ООО');
                                    INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (3, 'ОАО');
                                    INSERT INTO `edocbase`.`agent_types` (`id`, `name`) VALUES (4, 'ЗАО');

                                    SET foreign_key_checks = 1;"),
            
            //db updates emission_types
            new Migration(01, 08, @"UPDATE `edocbase`.`emission_types` SET `name` = 'Единичное производство' WHERE (`id` = 1)"),
            new Migration(01, 09, @"UPDATE `edocbase`.`emission_types` SET `name` = 'Серийный выпуск'        WHERE (`id` = 2)"),
            //db updates source_types
            new Migration(01, 10, @"UPDATE `edocbase`.`source_types` SET `name` = 'Лично в офисе'  WHERE (`id` = 1)"),
            new Migration(01, 11, @"UPDATE `edocbase`.`source_types` SET `name` = 'По телефону'    WHERE (`id` = 2)"),
            new Migration(01, 12, @"UPDATE `edocbase`.`source_types` SET `name` = 'Через интернет' WHERE (`id` = 3)"),
#endregion

#region DBMigration__02__2014_06_02
            //DBMigration #02 [2014-06-02]

            //change structure products
            new Migration(02, 01, @"ALTER TABLE `edocbase`.`products` CHANGE COLUMN `okp` `okp` VARCHAR(64) NULL DEFAULT NULL"),
            new Migration(02, 02, @"ALTER TABLE `edocbase`.`products` CHANGE COLUMN `tnved` `tnved` VARCHAR(64) NULL DEFAULT NULL"),
#endregion

        };

    }
}
