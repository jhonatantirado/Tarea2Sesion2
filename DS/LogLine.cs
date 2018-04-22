namespace NotacionBigO.DS
{
    public class LogLine {
        int counter;

        public LogLine(int counter) {
            this.counter = counter;
        }

        public string getIP() {
            return "ip-" + counter;
        }
    }
}