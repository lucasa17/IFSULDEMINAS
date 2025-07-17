    public int pesquisa(int dado) {
        Node current = this.head;
        while (current != null) {
            if (current.data == dado) {
                return 1; // Dado encontrado
            }
            current = current.next;
        }
        return 0; // Dado não encontrado
    }
