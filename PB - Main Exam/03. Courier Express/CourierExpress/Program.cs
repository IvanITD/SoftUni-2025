// User Input
        double weight = double.Parse(Console.ReadLine());
        string serviceType = Console.ReadLine();
        int distance = int.Parse(Console.ReadLine());

        // Variables to store the price per kilometer based on weight
        double pricePerKm = 0.0;
        double surchargePercent = 0.0;

        // Determine the price per kilometer and surcharge percentage based on weight
        if (weight < 1)
        {
            pricePerKm = 0.03; // 3 stotinkas per kilometer
            surchargePercent = 0.80; // 80% surcharge for express
        }
        else if (weight >= 1 && weight <= 10)
        {
            pricePerKm = 0.05; // 5 stotinkas per kilometer
            surchargePercent = 0.40; // 40% surcharge for express
        }
        else if (weight >= 10 && weight <= 40)
        {
            pricePerKm = 0.10; // 10 stotinkas per kilometer
            surchargePercent = 0.05; // 5% surcharge for express
        }
        else if (weight >= 40 && weight <= 90)
        {
            pricePerKm = 0.15; // 15 stotinkas per kilometer
            surchargePercent = 0.02; // 2% surcharge for express
        }
        else if (weight >= 90 && weight <= 150)
        {
            pricePerKm = 0.20; // 20 stotinkas per kilometer
            surchargePercent = 0.01; // 1% surcharge for express
        }

        // Calculate the base cost for "standard" service
        double baseCost = pricePerKm * distance;

        // If the service type is "express", apply the surcharge
        double totalCost = 0.0;
        if (serviceType == "standard")
        {
            totalCost = baseCost; // No surcharge for standard service
        }
        else if (serviceType == "express")
        {
            double surchargePerKm = pricePerKm * surchargePercent;
            double totalSurcharge = surchargePerKm * weight * distance;
            totalCost = baseCost + totalSurcharge; // Add surcharge to the base cost
        }

        // Round the values as required
        weight = Math.Round(weight, 3);
        totalCost = Math.Round(totalCost, 2);

        // Output the result
        Console.WriteLine($"The delivery of your shipment with weight of {weight:F3} kg. would cost {totalCost:F2} lv.");