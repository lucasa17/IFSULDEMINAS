public void removerElementosPares() {
        while (this.head != null && this.head.data % 2 == 0) {
            this.head = this.head.next;
        }

        Node current = this.head;
        while (current != null && current.next != null) {
            if (current.next.data % 2 == 0) {
                current.next = current.next.next; 
            } else {
                current = current.next; 
            }
        }
    }
