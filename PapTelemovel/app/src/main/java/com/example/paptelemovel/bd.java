package com.example.paptelemovel;

public class bd
{
    static public String ip = "http://192.168.126.8:5000/";
    static public class Ocorrencia{
        private int id;
        private String motivo;
        private String descricao;
        private String data;
        private byte[] foto;
        private String matricula;
        private int idEstadoOcorrencia;
        public Ocorrencia(int id, String motivo, String descricao, String data, byte[] foto, String matricula, int idEstadoOcorrencia) {
            this.id = id;
            this.motivo = motivo;
            this.descricao = descricao;
            this.data = data;
            this.foto = foto;
            this.matricula = matricula;
            this.idEstadoOcorrencia = idEstadoOcorrencia;
        }

        // Getters
        public int getId() {
            return id;
        }

        public String getMotivo() {
            return motivo;
        }

        public String getDescricao() {
            return descricao;
        }

        public String getData() {
            return data;
        }

        public byte[] getFoto() {
            return foto;
        }

        public String getMatricula() {
            return matricula;
        }

        public String getIdEstadoOcorrencia() {
            if(idEstadoOcorrencia==0){
                return "Por Analisar";
            } else if (idEstadoOcorrencia==1) {
                return "Em Análise";
            }else{
                return "Finalizada";
            }
        }

        // Setters
        public void setId(int id) {
            this.id = id;
        }

        public void setMotivo(String motivo) {
            this.motivo = motivo;
        }

        public void setDescricao(String descricao) {
            this.descricao = descricao;
        }

        public void setData(String data) {
            this.data = data;
        }

        public void setFoto(byte[] foto) {
            this.foto = foto;
        }

        public void setMatricula(String matricula) {
            this.matricula = matricula;
        }

        public void setIdEstadoOcorrencia(int idEstadoOcorrencia) {
            this.idEstadoOcorrencia = idEstadoOcorrencia;
        }

    }
    static public class Pagamento {
        private int id;
        private String titulo;
        private double valor;
        private String data;
        private int estado;


        public Pagamento(int id,String titulo, double valor, String data, int estado) {
            this.id = id;
            this.titulo = titulo;
            this.valor = valor;
            this.data = data;
            this.estado = estado;
        }
        public Integer getId() {
            return id;
        }
        public void setId(Integer id) {
            this.id = id;
        }

        public String getTitulo() {
            return titulo;
        }

        public void setTitulo(String titulo) {
            this.titulo = titulo;
        }

        public double getValor() {
            return valor;
        }

        public void setValor(double valor) {
            this.valor = valor;
        }

        public String getData() {
            return data;
        }

        public void setData(String data) {
            this.data = data;
        }

        public String getEstado() {
            if (this.estado==0){
                return "Por Pagar";
            }else{
                return "Pago";
            }
        }

        public void setEstado(int estado) {
            this.estado = estado;
        }
    }
    static public class Carro{
        private int id;
        private String matricula;
        private String marca;
        public Carro(int id,String matricula,String marca) {
            this.id = id;
            this.matricula = matricula;
            this.marca =marca;
        }
        public Integer getId() {
            return id;
        }
        public void setId(Integer id) {
            this.id = id;
        }


        public String getMatricula() {
            return matricula;
        }

        public void setMatricula(String matricula) {
            this.matricula = matricula;
        }
        public String getMarca() {
            return (marca == null || marca.equals("null")) ? "" : marca;
        }

        public void setMarca(String marca) {
            this.marca = marca;
        }
    }

}
