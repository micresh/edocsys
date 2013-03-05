
GRANT ALL PRIVILEGES ON edocbase.* TO admin IDENTIFIED BY 'wepo23nri_)(*';

CREATE USER 'defuser'@'%' IDENTIFIED BY 'ttrr';
GRANT SELECT ON edocbase.users TO 'defuser'@'%';
GRANT SELECT ON *.* TO 'defuser'@'%';


FLUSH PRIVILEGES;