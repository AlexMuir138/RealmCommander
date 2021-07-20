CREATE TABLE IF NOT EXISTS knights (  
    id int NOT NULL AUTO_INCREMENT,
    name varchar(255) NOT NULL,
    create_time DATETIME COMMENT 'create time',
    update_time DATETIME COMMENT 'update time',
    PRIMARY KEY (id)
) default charset utf8 comment '';

CREATE TABLE IF NOT EXISTS quests (
  id int AUTO_INCREMENT NOT NULL,
  title VARCHAR(255) NOT NULL,
  description VARCHAR (255),
  completed TINYINT DEFAULT 0,

  PRIMARY KEY (id)
);

INSERT INTO knights (name) VALUES ("deez knights");

SELECT * FROM knights;

INSERT INTO quests (title, description, completed) VALUES ("Find deez's nuts", "y'know, wink wink", 0);
SELECT * FROM quests;

UPDATE quests
SET description = "I'm in danger", completed = 1 WHERE id = 1;

ALTER TABLE knights
ADD COLUMN weapon VARCHAR(255) DEFAULT "Sword";