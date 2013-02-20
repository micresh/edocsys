
GRANT ALL PRIVILEGES ON edocbase.* TO admin IDENTIFIED BY 'wepo23nri_)(*';

CREATE USER 'defuser'@'%' IDENTIFIED BY 'ttrr';
GRANT ALL SELECT ON edocbase.users TO 'defuser'@'%';

FLUSH PRIVILEGES;