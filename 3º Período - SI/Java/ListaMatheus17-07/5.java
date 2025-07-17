    public static String decimalParaBinarioRecursivo(int decimal) {
        if (decimal == 0) {
            return "0"; 
        } else if (decimal == 1) {
            return "1"; 
        } else {
      
            return decimalParaBinarioRecursivo(decimal / 2) + (decimal % 2);
        }
    }
