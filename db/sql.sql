SELECT
id,
agent_types_id,
name,
inn,
phone,
fax,
email,
address,
ogrn,
kpp,
okpo,
rs,
ks,
bik,
bank,
signing_authority_doc,
pers_status,
pers_lastname,
pers_firstname, 
pers_middlename
FROM
agents;


SELECT
agents.id,
agents.agent_types_id, 
agents.name,
agents.inn,
agents.phone,
agents.fax,
agents.email,
agents.address,
agents.ogrn,
agents.kpp,
agents.okpo,
agents.ks,
agents.rs,
agents.bank,
agents.bik,
agents.signing_authority_doc,
agents.pers_status,
agents.pers_lastname,
agents.pers_firstname,
agents.pers_middlename,
agent_types.name AS agent_types_name,
agent_types.id  AS agent_types_id,
CONCAT( agent_types.name, ' ', agents.name ) AS fullname, 
CONCAT( agents.pers_lastname, ' ', substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '.' ) AS contact_pers_name_FIO,
CONCAT( substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '. ', agents.pers_lastname ) AS contact_pers_name_IOF
FROM
agents
INNER JOIN agent_types ON agents.agent_types_id = agent_types.id;



SELECT
id,
agents_id,
person,
status,
phone,
fax,
email
FROM
agents_contacts;




SELECT
id,
products_id,
agents_id,
experts_id,
contract_status_id,
emission_types_id,
contract_types_id,
number,
date_proposal,
scheme_type,
add_data_proposal,
date_contract,
source_types_id,
date_real_resert,
date_planed_resert,
date_real_reatt_2,
date_planed_reatt_2,
date_real_reatt_1,
date_planed_reatt_1,
date_protocol_income,
date_sample_income,
date_start,
date_cash_income,
cash_income,
total_cost,
cost,
add_data_contract
FROM
contracts;



SELECT
id, contracts_id,
contract_types_id,
users_id, date_modify,
document
FROM
documents;


-- experts
SELECT
id,
firstname,
lastname,
middlename,
user_types_id, 
CONCAT(lastname, ' ', substr(firstname, 1, 1), '. ', substr(middlename, 1, 1), '.') AS fullname
FROM
users
WHERE user_types_id = 2;



SELECT
contract_types.id,
contract_types.name,
doc_templates.id AS doc_templates_id,
doc_templates.contract_types_id,
doc_templates.template,
(doc_templates.id IS NOT NULL) AS template_presence
FROM
contract_types
LEFT OUTER JOIN
doc_templates ON contract_types.id = doc_templates.contract_types_id;

-- Proposal
SELECT
Contracts.Add_data,
Contracts.Client_docs,
Contracts.Contract_number,
Contracts.Contract_type,
Contracts.Schem_type,
Contracts.emission_type,
Contracts.idContract,
Contracts.idProducts,
Contracts.Contract_status,
Products.Product_name,
Contracts.agent_id,
Agents.Ag_fullname
FROM
Contracts
INNER JOIN
Products ON Contracts.idProducts = Products.idProducts
INNER JOIN
Agents ON Contracts.agent_id = Agents.idAgents
WHERE
(Contracts.Contract_status = 0)



--AssignExpert
UPDATE       Contracts
SET                Contract_status = @Contract_status, expert_id = @expert_id
WHERE        (idContract = @Original_idContract)

-- ProcessTask
UPDATE       Contracts
SET
Contract_status = @Contract_status
WHERE        (idContract = @Original_idContract)

-- SendProposal
UPDATE       Contracts
SET                Contract_status = @Contract_status
WHERE        (idContract = @Original_idContract)

-- TaskFinished
UPDATE       Contracts
SET
Contract_status = @Contract_status
WHERE        (idContract = @Original_idContract)

-- TaskReady
UPDATE       Contracts
SET
Contract_status = @Contract_status
WHERE        (idContract = @Original_idContract)

-- TaskProcessd
UPDATE contracts SET
`Contract_start` = @Contract_start,
`Contract_1_reatt` = @Contract_next,
`Contract_2_reatt` = @Contract_next,
`Contract_resume` = @Contract_next,
WHERE
(`idContract` = @Original_idContract)

-- TaskStart
INSERT INTO `Exec_contracts` (idContract) VALUES (@idContract)

--user_add
INSERT INTO `users` (`login`, `password`, `type`, `log_database`) VALUES (@login, @password, @type, @log_database)


--contracts_info
SELECT
contracts.id,
contracts.number,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
products.name,
products.id AS products_id, 
agents.id AS agents_id,
agents.name AS agents_name,
agents.pers_lastname,
agents.pers_firstname,
agents.pers_middlename,
agent_types.id AS agent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname, 
CONCAT( agents.pers_lastname, ' ', substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '.' ) AS contact_pers_name_FIO,
CONCAT( substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '. ', agents.pers_lastname ) AS contact_pers_name_IOF

FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id


                         
--- --contracts_info_old
SELECT 
Contracts.idContract,
Contracts.emission_type,
Contracts.Client_docs,
Contracts.Schem_type,
Contracts.Add_data,
Contracts.Contract_value_1,
Contracts.Contract_value_full,
Contracts.Contract_number,
Contracts.Contract_status,
Contracts.Bid_type,
Contracts.Cash_income,
ContractTypes.name,
Exec_contracts.Contract_start,
Exec_contracts.Contract_1_reatt,
Exec_contracts.Contract_2_reatt,
Exec_contracts.Contract_resume,
Exec_contracts.exec_1_reatt,
Exec_contracts.exec_2_reatt,
Exec_contracts.exec_resume,
Exec_contracts.sample_income,
Exec_contracts.protocol_income,
Agents.Ag_type_id, 
Agents_types.Agent_type,
Agents.Ag_fullname,
Agents.Ag_INN,
Agents.Ag_tel,
Agents.Ag_fax,
Agents.Ag_addr,
Agents.Ag_mail,
Agents.Ag_OGRN,
Agents.Ag_KPP,
Agents.Ag_OKPO,
Agents.Ag_Rcou,
Agents.Ag_Kcou,
Agents.Ag_BIK,
Agents.Ag_bank,
Agents.Ag_doc,
Agents.Ag_pers_status,
Agents.Ag_pers_lastname,
Agents.Ag_pers_firstname,
Agents.Ag_pers_middlename,
CONCAT (Agents_types.Agent_type, ' ', Agents.Ag_fullname) AS Ag_name, 
CONCAT (Agents.Ag_pers_lastname, ' ', SUBSTR(Agents.Ag_pers_firstname, 1, 1), '. ', SUBSTR(Agents.Ag_pers_middlename, 1, 1), '.') AS Ag_FIO,
CONCAT (SUBSTR(Agents.Ag_pers_firstname, 1, 1), '. ', SUBSTR(Agents.Ag_pers_middlename, 1, 1), '. ', Agents.Ag_pers_lastname) AS Ag_IOF,
Products.Product_name,
Products.Product_OKP,
Products.Product_TNVED,
ProductAreas.name AS ProductAreaName,
Products.ProductArea,
Experts.Expert_Firstname,
Experts.Expert_Lastname,
Experts.Expert_Middlename
FROM
Contracts 
LEFT OUTER JOIN ContractTypes ON Contracts.Contract_type = ContractTypes.id
LEFT OUTER JOIN Exec_contracts ON Contracts.idContract = Exec_contracts.idContract
LEFT OUTER JOIN Products ON Contracts.idProducts = Products.idProducts
LEFT OUTER JOIN Experts ON Contracts.expert_id = Experts.idExperts
LEFT OUTER JOIN Agents ON Contracts.agent_id = Agents.idAgents
LEFT OUTER JOIN Agents_types ON Agents.Ag_type_id = Agents_types.idAgents_types
LEFT OUTER JOIN ProductAreas ON Products.ProductArea = ProductAreas.id
