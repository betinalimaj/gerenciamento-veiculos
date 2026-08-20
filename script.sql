CREATE TABLE marca (
    codigo SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL UNIQUE
);

CREATE TABLE veiculo (
    codigo SERIAL PRIMARY KEY,
    placa VARCHAR(10) NOT NULL UNIQUE,
    modelo VARCHAR(100) NOT NULL,
    ano INTEGER NOT NULL,
    tipo VARCHAR(20) NOT NULL,
    marca_codigo INTEGER NOT NULL,

    CONSTRAINT fk_veiculo_marca
        FOREIGN KEY (marca_codigo)
        REFERENCES marca(codigo)
        ON DELETE RESTRICT
);

CREATE TABLE log_transacao (
    codigo SERIAL PRIMARY KEY,
    data_hora TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
    acao VARCHAR(20) NOT NULL,
    tabela VARCHAR(50) NOT NULL,
    registro_codigo INTEGER NOT NULL
);

CREATE OR REPLACE FUNCTION registrar_log()
RETURNS TRIGGER AS
$$
BEGIN
    INSERT INTO log_transacao
    (
        data_hora,
        acao,
        tabela,
        registro_codigo
    )
    VALUES
    (
        CURRENT_TIMESTAMP,
        TG_OP,
        TG_TABLE_NAME,
        COALESCE(NEW.codigo, OLD.codigo)
    );

    IF TG_OP = 'DELETE' THEN
        RETURN OLD;
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER tg_marca_log
AFTER INSERT OR UPDATE OR DELETE
ON marca
FOR EACH ROW
EXECUTE FUNCTION registrar_log();

CREATE TRIGGER tg_veiculo_log
AFTER INSERT OR UPDATE OR DELETE
ON veiculo
FOR EACH ROW
EXECUTE FUNCTION registrar_log();