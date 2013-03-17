-- ContractsInfo
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.production_documents,
contracts.scheme_type,
contracts.add_data_proposal,
contracts.add_data_contract,
contracts.custom_gosts,
contracts.gosts_list,
contracts.prepayment,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
products.id AS pkproducts_id, 
products.name AS products_name,
products.tnved AS products_tnved,
products.okp AS products_okp,
agents.id AS agents_id,
agents.name AS agents_name,
agents.pers_lastname,
agents.pers_firstname,
agents.pers_middlename,
agent_types.id AS agent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname, 
CONCAT( agents.pers_lastname, ' ', substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '.' ) AS contact_pers_name_FIO,
CONCAT( substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '. ', agents.pers_lastname ) AS contact_pers_name_IOF,
contract_types.id AS contract_types_id,
contract_types.name AS contract_types_name,
(SELECT IFNULL((SELECT (documents.contract_types_id = 0) FROM documents WHERE (documents.contract_types_id = 0) AND (documents.contracts_id=contracts.id)), false)) AS has_proposal_document
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
WHERE
    (contracts.contract_status_id = 0)




DELETE FROM contracts
WHERE (id = @id)


INSERT INTO contracts
(products_id, agents_id, experts_id, contract_status_id, emission_types_id, contract_types_id,
    date_proposal, scheme_type, add_data_proposal, add_data_contract, production_documents, custom_gosts, 
    gosts_list, source_types_id, prepayment, cost, total_cost, cash_income)
VALUES
(@products_id, @agents_id, @experts_id, @contract_status_id, @emission_types_id, @contract_types_id,
    @date_proposal, @scheme_type, @add_data_proposal, @add_data_contract, @production_documents, @custom_gosts,
    @gosts_list, @source_types_id, @prepayment, @cost, @total_cost, 0)



UPDATE contracts
SET
products_id = @products_id,
agents_id = @agents_id,
experts_id = @experts_id,
contract_status_id = @contract_status_id,
contract_types_id = @contract_types_id,
date_proposal = @date_proposal,
add_data_contract = @add_data_contract,
scheme_type = @scheme_type,
add_data_proposal = @add_data_proposal,
production_documents = @production_documents,
custom_gosts = @custom_gosts,
gosts_list = @gosts_list,
source_types_id = @source_types_id,
prepayment = @prepayment,
cost = @cost,
total_cost = @total_cost,
cash_income = 0
WHERE
(id = @original_id)


-- SendProposal
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)

-- !-----------------------------------------------------------


-- GOSTSelection
SELECT
selected_gosts.id,
selected_gosts.contracts_id,
selected_gosts.product_gosts_id,
selected_gosts.using_gost,
product_gosts.id AS product_gosts_id_real,
product_gosts.number,
product_gosts.type,
product_gosts.products_id
FROM
selected_gosts
INNER JOIN
product_gosts ON selected_gosts.product_gosts_id = product_gosts.id
WHERE
(product_gosts.products_id = @products_id)
AND
(selected_gosts.contracts_id = @contracts_id)


UPDATE
selected_gosts
SET
using_gost = @using_gost
WHERE
(contracts_id = @contracts_id)
AND
(product_gosts_id = @product_gosts_id)


-- GOSTSelection
SELECT
selected_gosts.id,
selected_gosts.contracts_id,
selected_gosts.product_gosts_id,
selected_gosts.using_gost,
product_gosts.id AS product_gosts_id_real,
product_gosts.number,
product_gosts.type,
product_gosts.products_id
FROM
selected_gosts
INNER JOIN
product_gosts ON selected_gosts.product_gosts_id = product_gosts.id
WHERE
selected_gosts.contracts_id = @contracts_id


-- ClearAll
DELETE FROM
selected_gosts
WHERE
(contracts_id = @contracts_id)

-- FillAll
INSERT INTO
selected_gosts
(contracts_id, using_gost, product_gosts_id)
SELECT @contracts_id AS cid, '0', product_gosts.id FROM product_gosts WHERE (product_gosts.products_id = @product_gosts_id)


-- !-----------------------------------------------------------

-- ExpertAssignment
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.cost,
contracts.total_cost,
products.id AS products_id,
products.name AS products_name,
agents.id AS agents_id,
agents.name AS agents_name,
agent_types.id AS agent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname, 
CONCAT('(', contracts.id, ') ', agents.name, '. ', products.name) AS contract_fullname,
contract_types.id AS contract_types_id,
contract_types.name AS contract_types_name
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
WHERE
    (contracts.contract_status_id = 1)


-- AssignExpert
UPDATE
contracts
SET
contract_status_id = @contract_status_id,
experts_id = @experts_id
WHERE
(id = @original_id)




-- !-----------------------------------------------------------

-- AssignedContracts
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.cost,
contracts.total_cost,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
    (contracts.contract_status_id >= 2)


-- !-----------------------------------------------------------

-- ContractSigning
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.prepayment,
contracts.cost,
contracts.total_cost,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO,
(SELECT IFNULL((SELECT (documents.contract_types_id > 9) FROM documents WHERE (documents.contract_types_id > 9) AND (documents.contracts_id=contracts.id)), false)) AS has_contract_document
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 2)




UPDATE
contracts
SET
number = @number,
prepayment = @prepayment,
cost = @cost,
total_cost = @total_cost,
date_contract = @date_contract
WHERE
(id = @original_id)


-- ConfirmSigning
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)



-- !-----------------------------------------------------------



-- ContractPrepareForWork
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 3)


UPDATE
contracts
SET
number = @number,
date_contract = @date_contract,
date_start = @date_start,
date_end = @date_end,
date_sample_income = @date_sample_income,
date_protocol_income = @date_protocol_income
WHERE
(id = @original_id)


-- StartWork
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)

-- !-----------------------------------------------------------


-- ContractInWork
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
(contracts.date_end - CURDATE()) as days_to_deadline,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 4)



-- WorkDone
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)

-- !-----------------------------------------------------------


-- ContractComplitionMgrCfm
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 5)



-- ConfirmFinished
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)




-- !-----------------------------------------------------------

-- ContractDone
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO,
(SELECT IFNULL((SELECT (documents.contract_types_id = 1) FROM documents WHERE (documents.contract_types_id = 1) AND (documents.contracts_id=contracts.id)), false)) AS has_act_document
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 6)


-- ConfirmContractDone
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)


-- SendContractToInspectionControl
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)

-- !-----------------------------------------------------------

-- ContractPayments
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
(contracts.date_end - CURDATE()) as days_to_deadline,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cash_income,
contracts.date_cash_income,
contracts.prepayment,
contracts.cost,
contracts.total_cost,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id > 0)
AND 
(contracts.contract_status_id < 9)
AND
(not contracts.cash_income)



-- SetPaymentComplete
UPDATE
contracts
SET
cash_income = @cash_income,
date_cash_income = @date_cash_income
WHERE
(id = @original_id)


-- !-----------------------------------------------------------


-- FinishedContracts
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
contracts.date_cash_income,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 9)


-- !-----------------------------------------------------------



-- InspectionContracts
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
contracts.date_cash_income,
contracts.date_planed_reatt_1,
contracts.date_real_reatt_1,
contracts.date_planed_reatt_2,
contracts.date_real_reatt_2,
contracts.date_planed_resert,
contracts.date_real_resert,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO,
(SELECT IFNULL((SELECT (documents.contract_types_id = 2) FROM documents WHERE (documents.contract_types_id = 2) AND (documents.contracts_id=contracts.id)), false)) AS has_inspection_document
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 7)



UPDATE
contracts
SET
date_planed_reatt_1 = @date_planed_reatt_1,
date_real_reatt_1 = @date_real_reatt_1,
date_planed_reatt_2 = @date_planed_reatt_2,
date_real_reatt_2 = @date_real_reatt_2,
date_planed_resert = @date_planed_resert,
date_real_resert = @date_real_resert
WHERE
(id = @original_id)


-- StartInspectionControl
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)

-- !-----------------------------------------------------------



-- !-----------------------------------------------------------

-- ContractsOnInspection
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
contracts.date_cash_income,
contracts.date_planed_reatt_1,
contracts.date_real_reatt_1,
contracts.date_planed_reatt_2,
contracts.date_real_reatt_2,
contracts.date_planed_resert,
contracts.date_real_resert,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id = 8)



UPDATE
contracts
SET
date_planed_reatt_1 = @date_planed_reatt_1,
date_real_reatt_1 = @date_real_reatt_1,
date_planed_reatt_2 = @date_planed_reatt_2,
date_real_reatt_2 = @date_real_reatt_2,
date_planed_resert = @date_planed_resert,
date_real_resert = @date_real_resert
WHERE
(id = @original_id)

-- FinishInspectionControl
UPDATE
contracts
SET
contract_status_id = @contract_status_id
WHERE
(id = @original_id)
-- !-----------------------------------------------------------


-- BadContracts
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
contracts.date_cash_income,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id > 9)


-- !-----------------------------------------------------------

-- PayedContracts
SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
contracts.date_proposal,
contracts.experts_id,
contracts.number,
contracts.date_contract,
contracts.date_start,
contracts.date_end,
(contracts.date_end - CURDATE()) as days_to_deadline,
contracts.date_sample_income,
contracts.date_protocol_income,
contracts.cash_income,
contracts.date_cash_income,
contracts.prepayment,
contracts.cost,
contracts.total_cost,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,
CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
contract_status.id AS pkcontract_status_id,
contract_status.name AS contract_status_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO
FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN contract_status ON contracts.contract_status_id = contract_status.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
(contracts.contract_status_id > 0)
AND 
(contracts.contract_status_id < 9)
AND
(contracts.cash_income)



-- CancelPayment
UPDATE
contracts
SET
cash_income = @cash_income,
date_cash_income = @date_cash_income
WHERE
(id = @original_id)

-- !-----------------------------------------------------------

-- ContractDocData

SELECT
contracts.id,
contracts.products_id,
contracts.agents_id,
contracts.contract_types_id,
contracts.contract_status_id,
contracts.experts_id,
contracts.source_types_id,
DATE_FORMAT(contracts.date_proposal, '%d.%m.%Y') AS date_proposal,
contracts.scheme_type,
contracts.add_data_proposal,
contracts.add_data_contract,
contracts.gosts_list AS GOSTsList,
contracts.production_documents,
contracts.prepayment,
contracts.cost,
contracts.total_cost,
contracts.cash_income,
DATE_FORMAT(contracts.date_cash_income, '%d.%m.%Y') AS date_cash_income,
contracts.number,
DATE_FORMAT(contracts.date_contract, '%d.%m.%Y') AS date_contract,
DATE_FORMAT(contracts.date_start, '%d.%m.%Y') AS date_start,
DATE_FORMAT(contracts.date_end, '%d.%m.%Y') AS date_end,
DATE_FORMAT(contracts.date_sample_income, '%d.%m.%Y') AS date_sample_income,
DATE_FORMAT(contracts.date_protocol_income, '%d.%m.%Y') AS date_protocol_income,
contracts.emission_types_id,
DATE_FORMAT(contracts.date_planed_reatt_1, '%d.%m.%Y') AS date_planed_reatt_1,
contracts.date_real_reatt_1,
DATE_FORMAT(contracts.date_planed_reatt_2, '%d.%m.%Y') AS date_planed_reatt_2,
contracts.date_real_reatt_2,
DATE_FORMAT(contracts.date_planed_resert, '%d.%m.%Y') AS date_planed_resert,
contracts.date_real_resert,
products.id AS pkproducts_id,
products.name AS products_name,
agents.id AS pkagents_id,
agents.name AS agents_name,
agents.agent_types_id AS pkagent_types_id,
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
agent_types.id AS pkagent_types_id,
agent_types.name AS agent_types_name,

CONCAT( agent_types.name, ' ', agents.name ) AS agents_fullname, 
CONCAT( agents.pers_lastname, ' ', substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '.' ) AS contact_pers_name_FIO,
CONCAT( substr(agents.pers_firstname, 1, 1), '. ', substr(agents.pers_middlename, 1, 1), '. ', agents.pers_lastname ) AS contact_pers_name_IOF,
contract_types.id AS pkcontract_types_id,
contract_types.name AS contract_types_name,
emission_types.id AS pkemission_types_id,
emission_types.name AS emission_types_name,
CONCAT( users.lastname, ' ', substr(users.firstname, 1, 1), '. ', substr(users.middlename, 1, 1), '.' ) AS expert_FIO,

(SELECT person
 FROM agents_contacts
WHERE (agents_contacts.agents_id = agents.id)
LIMIT 0,1
) AS Bukh_FIO

FROM
contracts
LEFT OUTER JOIN agents ON contracts.agents_id = agents.id
LEFT OUTER JOIN products ON contracts.products_id = products.id
LEFT OUTER JOIN agent_types ON agents.agent_types_id = agent_types.id
LEFT OUTER JOIN contract_types ON contracts.contract_types_id = contract_types.id
LEFT OUTER JOIN emission_types ON contracts.emission_types_id = emission_types.id
LEFT OUTER JOIN users ON contracts.experts_id = users.id
WHERE
    (contracts.id = @contracts_id)


-- !-------------------------------------------------------------------

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


--user_add
INSERT INTO `users` (`login`, `password`, `type`, `log_database`) VALUES (@login, @password, @type, @log_database)
