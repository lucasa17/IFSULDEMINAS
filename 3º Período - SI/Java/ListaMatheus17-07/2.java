 public boolean estaEmOrdemCrescente() {
        if (this.head == null || this.head.next == null) {
            return true;
        }

        Node current = this.head;
        while (current.next != null) {
            if (current.data > current.next.data) {
                return false; 
            }
            current = current.next;
        }
        return true;
    }
