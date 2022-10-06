function attachEventsListeners() {
    Array.from(document.querySelectorAll('input[type="button"]'))
       .forEach(btn => btn.addEventListener('click',convert));

    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

   function convert(event){
     switch (event.target.id) {
          case 'daysBtn':
               const daysInput = days.value;
               hours.value = Number(daysInput) * 24;
               minutes.value = Number(hours.value) * 60;
               seconds.value = Number(minutes.value) * 60;
          break;
          case 'hoursBtn':
               const hoursInput = hours.value;
               days.value = Number(hoursInput) / 24;
               minutes.value = Number(hoursInput) * 60;
               seconds.value = Number(minutes.value) * 60;
          break;
          case 'minutesBtn':
               const minutesInput = minutes.value;
               days.value = Number(minutesInput) / 1440;
               hours.value = Number(minutesInput) / 60;
               seconds.value = Number(minutesInput) * 60;
          break;
          case 'secondsBtn':
               const secondsInput = seconds.value;
               days.value = Number(secondsInput) / 86400;
               hours.value = Number(secondsInput) / 3600;
               minutes.value = Number(secondsInput) / 60;
          break;
     }
   }
}