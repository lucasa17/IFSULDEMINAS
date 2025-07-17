 public boolean estaEmOrdemCrescente() {
        if (this.head == null || this.head.next == null) {
            return true; // Lista vazia ou com um único elemento está sempre em ordem
        }

        Node current = this.head;
        while (current.next != null) {
            if (current.data > current.next.data) {
                return false; // Encontrou um elemento maior que o próximo
            }
            current = current.next;
        }
        return true; // Todos os elementos estão em ordem
    }
