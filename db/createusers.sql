CREATE USER 'admin'@'%' IDENTIFIED BY 'wepo23nri_)(*';
CREATE USER 'defuser'@'%' IDENTIFIED BY 'ttrr';

-- GRANT SELECT, INSERT, DELETE, UPDATE, CREATE, DROP, ALTER ON edocbase.* TO admin;

GRANT ALL PRIVILEGES ON edocbase.* TO admin IDENTIFIED BY 'wepo23nri_)(*';

GRANT SELECT ON edocbase.users TO 'defuser'@'%';
GRANT SELECT ON *.* TO 'defuser'@'%';


FLUSH PRIVILEGES;