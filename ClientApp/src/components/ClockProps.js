export default class ClockProps {
  constructor() {
    this.fontFamily = 'courier'
    this.availableFontSizes = [12, 24, 48, 64]
    this.titleFontSize = 64
    this.clockFontSize = 48
    this.blinkColons = true
    this.fontColor = 'black'
    this.Timer = ""
    }

    updateTimer() {
        const currentDate = new Date();
        const year = currentDate.getFullYear();
        const month = (currentDate.getMonth() + 1).toString().padStart(2, '0');
        const day = currentDate.getDate().toString().padStart(2, '0');
        const hours = currentDate.getHours().toString().padStart(2, '0');
        const minutes = currentDate.getMinutes().toString().padStart(2, '0');
        const seconds = currentDate.getSeconds().toString().padStart(2, '0');
        this.Timer = `${year}-${month}-${day}T${hours}:${minutes}:${seconds}`;
    }
}
